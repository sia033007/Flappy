using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shop : MonoBehaviour {

	int SceneIndex;

	// Use this for initialization
	void Start () {
		SceneIndex = SceneManager.GetActiveScene ().buildIndex;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape))
			SceneManager.LoadScene (SceneIndex - 12);
		
	}
}
