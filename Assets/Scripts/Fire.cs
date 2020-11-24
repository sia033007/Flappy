﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire : MonoBehaviour
{
    
   
    public Animator anim;
    public Slider slider1;
    public Slider slider2;
    public Slider slider4;
    public Slider slider5;  
    
   


    void Start()
    {
       
       anim=GetComponent<Animator>();
       slider1=GameObject.Find("Canvas").GetComponent<UIEnemy1>().slider;
	   slider2=GameObject.Find("Canvas").GetComponent<UIEnemy1>().slider3;
       slider4=GameObject.Find("Canvas").GetComponent<UIEnemy1>().slider4;
       slider5=GameObject.Find("Canvas").GetComponent<UIEnemy1>().slider5;
       
       
    }

    void Awake (){
    	
    }

    void OnTriggerEnter2D (Collider2D coli){

		if (coli.tag == "Obstacle" || coli.tag== "ger") {
			Destroy (coli.gameObject);
			gameObject.SetActive(false);
			anim.enabled=!anim.enabled;

		}

	}
	void OnTriggerStay2D (Collider2D col){

		if (col.tag == "Bubble") {
			slider1.value++;
			Destroy(gameObject);
			anim.enabled=!anim.enabled;
		}
        if(col.tag == "Bubble2"){
            slider4.value++;
            Destroy(gameObject);
            anim.enabled=!anim.enabled;
        }

	}
	void OnTriggerExit2D (Collider2D enemy){

		if (enemy.tag == "Enemy") {
			slider2.value++;
			Destroy(gameObject);
			anim.enabled=!anim.enabled;
		}
        if(enemy.tag == "Enemy2"){
            slider5.value++;
            Destroy(gameObject);
            anim.enabled=!anim.enabled;
        }

	}

    // Update is called once per frame
    void Update(){
        if(gameObject.activeInHierarchy==true){
            Destroy(gameObject,2f);
        }


    }   
}