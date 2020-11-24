using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet511 : MonoBehaviour
{
  public Rigidbody2D rb;
  public float speed=0.75f;
 


	// Use this for initialization
	void Start () {
		rb.velocity = new Vector2 (2 * 15, speed*15);
		
		}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D coli){

		if (coli.tag == "Obstacle" || coli.tag== "ger") {
			Destroy (coli.gameObject);
			Destroy (gameObject);
		}

	}	
}

