using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble3 : MonoBehaviour {






	void Start() {


	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "ger") {
			Destroy (col.gameObject);

			GetComponent<AudioSource> ().Play ();


		}
	}


}


