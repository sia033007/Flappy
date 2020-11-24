using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu2 : MonoBehaviour {

	int SceneIndex;

	public Button easymode;
	public Button hardmode;

	public static int mode_number;

	// Use this for initialization
	void Start () {
		SceneIndex = SceneManager.GetActiveScene ().buildIndex;



		easymode.onClick.AddListener (()=> {
			mode_number=1;
			SceneManager.LoadScene ("Menu4");

		});

		hardmode.onClick.AddListener (() => {

			mode_number=2;
		    SceneManager.LoadScene ("Menu4");

		});

	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (Input.GetKeyDown (KeyCode.Escape))
			SceneManager.LoadScene (SceneIndex - 1);

	}

}
		


