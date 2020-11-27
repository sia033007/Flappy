using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveToScoreBoard : MonoBehaviour
{
    public GameObject update;
    public InputField nameField;
    public Button backButton;

    // Start is called before the first frame update
    void Start()
    {
        if(ObscuredPrefs.GetString("save")=="On")
        {
            update.SetActive(true);
            backButton.gameObject.SetActive(true);

        }
        else
        {
            update.SetActive(false);
            backButton.gameObject.SetActive(false);
        }
        
    }
    public void SaveScore()
    {
        HighScores.AddNewHighscore(nameField.text,DBManager.coin);
        StartCoroutine(disableupdate());
    }
    IEnumerator disableupdate()
    {
        yield return new WaitForSeconds(1f);
        update.SetActive(false);
    }
    public void Back()
    {
        SceneManager.UnloadSceneAsync("Leader");

    }
    private void Update() {
        if(ObscuredPrefs.GetString("save")!="On" && Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
