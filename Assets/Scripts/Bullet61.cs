﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet61 : MonoBehaviour
{
   public Rigidbody2D rb;
   public float speed=0.75f;
   public Slider slider1;
   public Slider slider2;
  
	// Use this for initialization
	void Start () {
		rb.velocity = new Vector2 (2 * 15, -speed*15);
		slider1=GameObject.Find("Canvas").GetComponent<UIEnemy2>().slider;
		slider2=GameObject.Find("Canvas").GetComponent<UIEnemy2>().slider3;
		

		}
	
	// Update is called once per frame
	void FixedUpdate () {

		
		
		
	}
	void OnTriggerEnter2D (Collider2D coli){

		if (coli.tag == "Obstacle" || coli.tag== "ger") {
			Destroy (coli.gameObject);
			Destroy (gameObject);
		}

	}
	void OnTriggerStay2D (Collider2D col){

		if (col.tag == "Bubble") {
			slider1.value++;
			Destroy (gameObject);
		}	
	}
	void OnTriggerExit2D (Collider2D enemy){

		if (enemy.tag == "Enemy") {
			slider2.value++;
			Destroy (gameObject);
		}	
	}
}

