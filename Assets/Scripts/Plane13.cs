// Code auto-converted by Control Freak 2 on Sunday, April 12, 2020!
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plane13 : MonoBehaviour {

	public float velocity= 1;
	private Rigidbody2D rb;
	private Camshake shake;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		shake = GameObject.FindGameObjectWithTag ("shake3").GetComponent<Camshake> ();


	}

	// Update is called once per frame
	void Update () {

		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0) {

			StartCoroutine (die ());
		}

		foreach (Touch t in Input.touches)
		{


			if (t.phase == TouchPhase.Began)
			{
				rb.velocity = Vector2.up * velocity;


			}
			else if(t.phase == TouchPhase.Ended)
			{
				Debug.Log ("touch end");

			}
		}


	}
		

	void OnCollisionEnter2D (Collision2D other) {

		StartCoroutine (die ());
	}

	IEnumerator die () {
		shake.shake ();
		yield return new WaitForSeconds (0.5f);
		SceneManager.LoadScene ("Plane222");
	}
}




