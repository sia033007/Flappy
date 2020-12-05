using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;

public class GameSave : MonoBehaviour
{
    private void Awake() {
        DontDestroyOnLoad(this);
    }
    private void OnApplicationFocus(bool focusStatus) {
        if(!focusStatus)
        {
            ObscuredPrefs.SetString ("Bonus","On");
     	    ObscuredPrefs.Save();        
            ObscuredPrefs.SetString("firstplay","no");
        }
    }
    private void OnApplicationPause(bool pauseStatus) {
        if(pauseStatus)
        {
            ObscuredPrefs.SetString ("Bonus","On");
     	    ObscuredPrefs.Save();      
            ObscuredPrefs.SetString("firstplay","no");
        }
    }   
}
