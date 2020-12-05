using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;

public class CodeCam11 : MonoBehaviour {

	int SceneIndex;
	public Animator anim;

	// Use this for initialization
	void Start () {
		SceneIndex = SceneManager.GetActiveScene ().buildIndex;
		anim=GetComponent<Animator>();
		StartCoroutine(ghool());

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			SceneManager.LoadScene (SceneIndex -3);
		}

	}
	IEnumerator ghool (){
		yield return new WaitForSeconds (3f);
		anim.SetTrigger ("trig1");
		yield return new WaitForSeconds (3f);
		anim.SetTrigger ("trig2");

		StartCoroutine (ghool());
	}
}


