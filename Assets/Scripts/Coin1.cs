using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin1 : MonoBehaviour {

	public float speed;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		transform.position += Vector3.down * speed * Time.deltaTime;
		}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player") {
			BonusUI.score++;
			gameObject.SetActive (false);
		}		
	}
}


