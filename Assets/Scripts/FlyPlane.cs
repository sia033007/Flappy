using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyPlane : MonoBehaviour {

	public float velocity= 1;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();

		
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0) {

			die ();
		}






		if (Input.GetMouseButtonDown (0)) {

			rb.velocity = Vector2.up * velocity;

		}
		
	}

	void OnCollisionEnter2D (Collision2D other) {

		die ();
		}

	void die () {
		SceneManager.LoadScene ("Main");


	}
}
