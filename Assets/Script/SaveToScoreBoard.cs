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

    // Start is called before the first frame update
    void Start()
    {
        if(ObscuredPrefs.GetString("save")=="On")
        {
            update.SetActive(true);
        }
        
    }
    public void SaveScore()
    {
        HighScores.AddNewHighscore(nameField.text,DBManager.coin);
        update.SetActive(false);
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
        ObscuredPrefs.SetString ("Bonus","Off");
    }
}
