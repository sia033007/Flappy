﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlanePause4 : MonoBehaviour
{
	public GameObject pausepanel,win;
	public AudioSource[]aud;
	public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
       PlayerPrefs.GetString("Level6");  
    }

    // Update is called once per frame
    void Update()
    {
    	if(win.activeInHierarchy==true){
    		PlayerPrefs.SetString("Level6","On");
    	}
       if(Input.GetKeyDown(KeyCode.Escape)){
			pausepanel.SetActive(true);
		    Time.timeScale = 0;
		    aud[0].Pause();
		    aud[1].Pause();
		}
    }
    public void reload(){
		pausepanel.SetActive(false);
		SceneManager.LoadScene ("Western2");
		aud[0].UnPause();
		aud[1].UnPause();
		Time.timeScale=1;
		
	}

	public void resume(){
		pausepanel.SetActive(false);
		aud[0].UnPause();
		Time.timeScale=1;
		if(slider.value>25 && slider.value<=32){
			aud[1].UnPause();
		}
		else{
			aud[1].Pause();
		}
	}
	public void home(){

	}
}
