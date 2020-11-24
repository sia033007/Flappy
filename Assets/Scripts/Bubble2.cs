using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble2 : MonoBehaviour {





	
	void Start() {

		
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Obstacle") {
			Destroy (col.gameObject);

		GetComponent<AudioSource> ().Play ();

	
		}
	}


}


