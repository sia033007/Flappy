using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public GameObject warnplay, welcomeDisplay;
    public Text playerDisplay;
    public Button registerButton, loginButton, playButton;

    private void Start() {
        if(DBManager.LoggedIn)
        {
            playerDisplay.text = DBManager.username;
            welcomeDisplay.SetActive(true);

        }
        registerButton.interactable = !DBManager.LoggedIn;
        loginButton.interactable = !DBManager.LoggedIn;
        playButton.interactable = DBManager.LoggedIn;
    }
    public void Register()
    {
        SceneManager.LoadScene("Register");
    }
    public void Login()
    {
        SceneManager.LoadScene("Login");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Menu");
    }
    IEnumerator loginfirst()
    {
        if(playButton.interactable == false)
        {
            yield return new WaitForSeconds(1f);
            warnplay.SetActive(true);
            yield return new WaitForSeconds(3f);
            warnplay.SetActive(false);          
        }      
    }
    public void checkLog()
    {
        StartCoroutine(loginfirst());
    }
}
