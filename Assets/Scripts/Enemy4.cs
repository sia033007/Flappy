﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy4 : MonoBehaviour
{
    
    public Slider slider;
	public Slider slider2;
	public Slider slider3;
	public GameObject bubble;
	public float timer;
	public int delay = 1;
	public Animator anim;
	public GameObject bullet;
	public GameObject bullets;
	public Transform tr1;
	public Transform tr2;
	public float speed=3.5f;
	
	
    // Start is called before the first frame update
    void Start()
    {
        slider=GameObject.Find("Canvas").GetComponent<UIEnemy2>().slider;
        slider2=GameObject.Find("Canvas").GetComponent<UIEnemy2>().slider1;
        slider3=GameObject.Find("Canvas").GetComponent<UIEnemy2>().slider3;
        anim=GetComponent<Animator>();
        InvokeRepeating ("shoot",2f,1f);
        
       

        
        

    }

    // Update is called once per frame
    void Update()
    {
    	timer += Time.deltaTime;

    	if (timer >= delay && bubble.activeInHierarchy==false) {
			timer = 0f;
			slider.value-=speed;
		}
        if(slider.value==40){
        	bubble.SetActive(false);
        	bullets.SetActive(true);
        	InvokeRepeating("shoots",2f,5f);
        	StartCoroutine(go1());

        	
        	
        }

        if(slider.value==0){
        	bubble.SetActive(true);
        	bullets.SetActive(false);
        	StartCoroutine(go());
        	
        }

        if(slider3.value==80){
        	Destroy (gameObject);
        }
        
       
    }

    void shoot(){
    	Instantiate(bullet,tr1.position,transform.rotation);
    }
    void shoots(){
    	Instantiate(bullets,tr2.position,transform.rotation);
    }

    IEnumerator go (){
    	yield return new WaitForSeconds(4f);
    	anim.SetInteger("move",1);
    	yield return new WaitForSeconds (1f);
    	anim.SetInteger ("move",2);
    	yield return new WaitForSeconds (1f);
    	anim.SetInteger("move",3);
    	yield return new WaitForSeconds(4f);
    	anim.SetInteger("move",1);
    	yield return new WaitForSeconds (1f);
    	anim.SetInteger ("move",2);
    	yield return new WaitForSeconds (1f);
    	anim.SetInteger("move",3);
    
    }

    IEnumerator go1 (){
    	anim.SetTrigger ("trig2");
    	yield return new WaitForSeconds (3f);
    	anim.SetTrigger ("trig3");
    	yield return new WaitForSeconds (3f);
    	anim.SetTrigger("trig2");
    	yield return new WaitForSeconds (3f);
    	anim.SetTrigger("trig2");
    }
    
    void OnCollisionEnter2D (Collision2D col){
    	if(col.gameObject.tag== "Player"){
    		slider2.value+=2;

    	}
    }
    
}
