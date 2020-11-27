using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Login : MonoBehaviour
{
    public GameObject success, failed1, failed2, failed3;
    public InputField nameField;
    public InputField passField;
    public Button submitButton;

    public void Logins()
    {
        StartCoroutine(loginPlayer());
    }
    IEnumerator loginPlayer()
    {
        WWWForm form = new WWWForm();
        form.AddField("name",nameField.text);
        form.AddField("password",passField.text);
        using(UnityWebRequest request = UnityWebRequest.Post("http://aminunity.orgfree.com/samplelogin.php",form))
        {
            yield return request.SendWebRequest();
            if(request.downloadHandler.text[0] == '0')
            {
                DBManager.username = nameField.text;
                DBManager.coin = int.Parse(request.downloadHandler.text.Split('\t')[1]);
                DBManager.level = int.Parse(request.downloadHandler.text.Split('\t')[2]);
                DBManager.planetwo = int.Parse(request.downloadHandler.text.Split('\t')[3]);
                DBManager.planethree = int.Parse(request.downloadHandler.text.Split('\t')[4]);
                DBManager.planefour = int.Parse(request.downloadHandler.text.Split('\t')[5]);
                DBManager.planefive = int.Parse(request.downloadHandler.text.Split('\t')[6]);
                DBManager.dragon = int.Parse(request.downloadHandler.text.Split('\t')[7]);
                StartCoroutine(mainmenu());
                StartCoroutine(successful());
                Debug.Log("Log in successfully!");


            }
            else if(request.downloadHandler.text == "1")
            {
                StartCoroutine(fail1());
                Debug.Log(request.downloadHandler.text);
            }
            else if(request.downloadHandler.text == "3")
            {
                StartCoroutine(fail2());
                Debug.Log(request.downloadHandler.text);
            }
            else if(request.downloadHandler.text == "4")
            {
                StartCoroutine(fail3());
                Debug.Log(request.downloadHandler.text);
            }
            else
            {
                Debug.Log("Log in failed" + request.downloadHandler.text);
            }
        }
    }
     public void VeryfyInput()
    {
        submitButton.interactable = (nameField.text.Length>8 && passField.text.Length>8);
    }
    IEnumerator successful()
    {
        success.SetActive(true);
        yield return new WaitForSeconds(3f);
        success.SetActive(false);
    }
    IEnumerator fail1()
    {
        failed1.SetActive(true);
        yield return new WaitForSeconds(3f);
        failed1.SetActive(false);
    }
    IEnumerator fail2()
    {
        failed2.SetActive(true);
        yield return new WaitForSeconds(3f);
        failed2.SetActive(false);
    }
    IEnumerator fail3()
    {
        failed3.SetActive(true);
        yield return new WaitForSeconds(3f);
        failed3.SetActive(false);
    }
    IEnumerator mainmenu()
    {
        yield return new WaitForSeconds(3f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("WlecomeScene");
    }
   
}
