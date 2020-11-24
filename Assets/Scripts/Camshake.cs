using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camshake : MonoBehaviour {
	public Animator anime;

	public void shake() {
		anime.SetTrigger ("shake");
	}




}
