﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;


public class BonusPlane2 : MonoBehaviour {

	private Rigidbody2D rb;
	public GameObject coin;
	public float height=5;
	public Slider slider;
	public AudioSource aud;
	public GameObject pause1,end;
	float movespeed=50f;
	float dirx;
	

	void Awake () {
			
	}


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();
		InvokeRepeating ("ins", 6f, 3f);
	}

	void Update ()
	{
		if(slider.value==35){
		    StartCoroutine (win());
		}
		
		if(pause1.activeInHierarchy==true || end.activeInHierarchy==true){
			GetComponent<AudioSource>().Pause();
		}
		else{
			GetComponent<AudioSource>().UnPause();
		}
		rb.velocity=new Vector2 (dirx,0f);
	}
	void FixedUpdate (){
	   dirx=Input.acceleration.x*movespeed;
	   transform.position=new Vector2 (Mathf.Clamp (transform.position.x,-7f,7f),transform.position.y);
	}

	void ins () {
		Instantiate (coin, new Vector3 (Random.Range (-height, height),5, 0), transform.rotation);
	}
	IEnumerator win (){
		yield return new WaitForSeconds(1f);
		DBManager.coin+=BonusUI.score;
	}
	void OnTriggerEnter2D (Collider2D col){
		if(col.tag == "Coin"){
			aud.Play();
		}	
	}
}








