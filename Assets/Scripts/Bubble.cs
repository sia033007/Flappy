using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour {

	public float speed;
	public Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		transform.position += Vector3.left * speed * Time.deltaTime;
	}


}


		
	


