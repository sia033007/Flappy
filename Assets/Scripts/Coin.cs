using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	public float speed;
	public AudioSource aud;


	// Use this for initialization
	void Start () {
		aud=GetComponent<AudioSource>();

	}

	// Update is called once per frame
	void Update () {

		transform.position += Vector3.left * speed * Time.deltaTime;
		}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player") {
			DBManager.coin++;
			aud.Play();
			gameObject.SetActive (false);
		}
	}
}


