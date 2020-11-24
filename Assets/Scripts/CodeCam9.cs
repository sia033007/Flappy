using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;

public class CodeCam9 : MonoBehaviour {
	public GameObject but;
	

	// Use this for initialization
	void Awake () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) && ObscuredPrefs.GetString("Shop")=="Off"){		
			SceneManager.LoadScene("Menu");			
		}
		if(ObscuredPrefs.GetString("Shop")=="On"){
			but.SetActive(true);
		}
	}
	public void ret(){		
		SceneManager.UnloadScene("shop");
	}
}
