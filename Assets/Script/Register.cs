using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Register : MonoBehaviour
{
    public GameObject success, failed1, failed2;
    public InputField nameField;
    public InputField passField;
    public Button submitButton;
    public void Registers()
    {
        StartCoroutine(Registration());
    }
    IEnumerator Registration()
    {
        WWWForm form = new WWWForm();
        form.AddField("name",nameField.text);
        form.AddField("password",passField.text);
        using(UnityWebRequest request = UnityWebRequest.Post("http://aminunity.orgfree.com/registersample.php",form))
        {
            yield return request.SendWebRequest();
            if(request.downloadHandler.text == "0")
            {
                StartCoroutine(successful());
                StartCoroutine(mainmenu());
                Debug.Log("User created successfully!");
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

        }
    }
    public void VeryfyInput()
    {
        submitButton.interactable = (nameField.text.Length>8 && passField.text.Length>8);
    }
    IEnumerator successful()
    {
        success.SetActive(true);
        yield return new WaitForSeconds (3f);
        success.SetActive(false);
    }
    IEnumerator fail1()
    {
        failed1.SetActive(true);
        yield return new WaitForSeconds (5f);
        failed1.SetActive(false);
    }
    IEnumerator fail2()
    {
        failed2.SetActive(true);
        yield return new WaitForSeconds (5f);
        failed2.SetActive(false);
    }
    IEnumerator mainmenu()
    {
        yield return new WaitForSeconds(3f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("WlecomeScene");
    }
}
