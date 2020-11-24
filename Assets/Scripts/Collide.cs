using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {

	private GameObject Player;
	private GameObject Cube;

	// Use this for initialization
	void Start () {

		Player = GameObject.FindGameObjectWithTag ("Player");
		Cube = GameObject.FindGameObjectWithTag ("Cube");
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void OnCollisionEnter(Collision collision) {

		if (collision.gameObject.tag == "Cube")
			Destroy (this.gameObject);
		
		
		}

}
