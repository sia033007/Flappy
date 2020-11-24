using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player3 : MonoBehaviour {

	public float velocity= 1;
	private Rigidbody2D rb;

	public GameObject BluePlane;
	public GameObject WhitePlane;
	public GameObject YellowPlane;
	public GameObject WarPlane1;
	public GameObject WarPlane2;

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






		if (Input.GetMouseButton (0)) {

			rb.velocity = Vector2.up * velocity;

		}

	}

	void OnCollisionEnter2D (Collision2D other) {

		die ();
	}

	void die () {
		SceneManager.LoadScene ("Plane22");



	}
}




