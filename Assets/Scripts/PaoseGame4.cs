using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaoseGame4 : MonoBehaviour {

	public GameObject Pause;


	public void Pause_Game () {

		Time.timeScale = 0;
		GetComponent<AudioSource> ().Pause ();

		Pause.SetActive (true);


	}


	public void resume () {

		Pause.SetActive (false);
		GetComponent<AudioSource> ().UnPause ();
		Time.timeScale = 1;
	}

	public void reload () {

		SceneManager.LoadScene ("Planelevel2");
		Time.timeScale = 1;
	}

	public void Home () {

		SceneManager.LoadScene ("Menu");
		Time.timeScale = 1;
	}

	// Use this for initialization


	void Start () {
		GetComponent<AudioSource> ().Play ();

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {

			Pause.SetActive (true);
			Time.timeScale = 0;
			GetComponent<AudioSource> ().Pause ();
		}

	}
}



