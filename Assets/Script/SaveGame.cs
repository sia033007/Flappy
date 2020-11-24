using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;

public class SaveGame : MonoBehaviour
{
    public Text userDisplay;
    public Text scoreDisplay;
    public Text levelDisplay;

    private void Awake() {
        DontDestroyOnLoad(this);
        userDisplay.text = DBManager.username;
        scoreDisplay.text =""+UIManager2.coin_score;
        levelDisplay.text = ""+DBManager.level;
    }
    public void saveData()
    {
        StartCoroutine(dataSave());
    }
    IEnumerator dataSave()
    {
        WWWForm form = new WWWForm();
        form.AddField("name",DBManager.username);
        form.AddField("score",UIManager2.coin_score);
        form.AddField("level",DBManager.level);
        using(UnityWebRequest request = UnityWebRequest.Post("http://aminunity.orgfree.com/samplegame.php",form))
        {
            yield return request.SendWebRequest();
            if(request.downloadHandler.text == "0")
            {
                Debug.Log("Game saved");
            }
            else
            {
                Debug.Log("Save failed" + request.downloadHandler.text);
            }
        }
    }
    private void OnApplicationFocus(bool focusStatus) {
        if(!focusStatus)
        saveData();
    }
    private void OnApplicationPause(bool pauseStatus) {
        if(pauseStatus)
        saveData();
    }
    
}
