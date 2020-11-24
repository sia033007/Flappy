using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulEnemy1 : MonoBehaviour
{
   public Rigidbody2D rb;
   public Slider slider1;
   public Slider slider2;



	// Use this for initialization
	void Start () {
		rb.velocity = new Vector2 (2 * 15, 0);
		slider1=GameObject.Find("Canvas").GetComponent<UIEnemy1>().slider;
		slider2=GameObject.Find("Canvas").GetComponent<UIEnemy1>().slider3;

		}
	
	// Update is called once per frame
	void FixedUpdate () {

		
		
		
	}
	void OnTriggerEnter2D (Collider2D col){

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
