using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide1 : MonoBehaviour {

	void OnCollisionExit2D (Collision2D col) {
		if (col.gameObject.tag == "Rock") {

			Destroy (col.gameObject, 1f);
		}
	}


}
