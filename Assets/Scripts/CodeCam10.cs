using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodeCam10 : MonoBehaviour {

	int SceneIndex;

	// Use this for initialization
	void Start () {
		SceneIndex = SceneManager.GetActiveScene ().buildIndex;

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			SceneManager.LoadScene (SceneIndex -3);


	}
}



