using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SaveButton : MonoBehaviour
{
   public Animator anim;
   public Button saveButton;
   public GameObject savePanel;
    // Start is called before the first frame update
    void Start()
    {
      anim=GetComponent<Animator>();
      StartCoroutine(but());
      saveButton.gameObject.SetActive(true);

    }
    IEnumerator but (){
    	yield return new WaitForSeconds (1f);
    	anim.SetInteger ("move",1);
    	yield return new WaitForSeconds (3f);
    	anim.SetInteger ("move",2);
    	StartCoroutine (but());
    }
   public void saveData()
    {
        StartCoroutine(dataSave());
    }
    IEnumerator dataSave()
    {
        WWWForm form = new WWWForm();
        form.AddField("name",DBManager.username);
        form.AddField("score",DBManager.coin);
        form.AddField("level",DBManager.level);
        form.AddField("planetwo",DBManager.planetwo);
        form.AddField("planethree",DBManager.planethree);
        form.AddField("planefour",DBManager.planefour);
        form.AddField("planefive",DBManager.planefive);
        form.AddField("dragon",DBManager.dragon);

        using(UnityWebRequest request = UnityWebRequest.Post("http://aminunity.orgfree.com/samplegame.php",form))
        {
            yield return request.SendWebRequest();
            if(request.downloadHandler.text == "0")
            {
                Debug.Log("Game saved");
                StartCoroutine(savePanels());
            }
            else
            {
                Debug.Log("Save failed" + request.downloadHandler.text);
            }
        }
    }
    IEnumerator savePanels()
    {
        savePanel.SetActive(true);
        yield return new WaitForSeconds(3f);
        savePanel.SetActive(false);

    }
}
