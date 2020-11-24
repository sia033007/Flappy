using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet111 : MonoBehaviour {

	public Rigidbody2D rb;
	
    



	// Use this for initialization
	void Start () {
		rb.velocity = new Vector2 (2 * 15, 0);
		
		

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
}
