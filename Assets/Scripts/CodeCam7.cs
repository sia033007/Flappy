using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;


public class CodeCam7 : MonoBehaviour {




	public GameObject BluePlane;
	public GameObject Plane2;
	public GameObject Plane3;
	public GameObject Plane4;
	public GameObject Plane5;
	public GameObject Dragon;

	// Use this for initialization
	void Start () {


		if (MainMenu3.chnum == 1) {

			BluePlane.SetActive (true);
		}

		if (MainMenu3.chnum == 2) {

			Plane2.SetActive (true);
		}

		if (MainMenu3.chnum == 3) {

			Plane3.SetActive (true);
		}

		if (MainMenu3.chnum == 4) {

			Plane4.SetActive (true);
		}

		if (MainMenu3.chnum == 5) {

			Plane5.SetActive (true);
		}

		if (MainMenu3.chnum == 6) {

			Dragon.SetActive (true);

		}
	}



	// Update is called once per frame
	void Update () {

		
	}
	public void menu(){
		Time.timeScale=1;
		SceneManager.LoadScene("Menu5");
	}
	public void home(){
		Time.timeScale=1;
		SceneManager.LoadScene("Menu");
	}
	public void home2(){
		StartCoroutine (house());

	}
	public void purchase (){
		StartCoroutine(shop());
		
	}

	IEnumerator house(){
		yield return new WaitForSecondsRealtime(1f);
		Time.timeScale=1;
		SceneManager.LoadScene("Menu");
	}

	IEnumerator shop (){
		yield return new WaitForSecondsRealtime (1f);
		Time.timeScale=1;
		SceneManager.LoadScene("shop",LoadSceneMode.Additive);
		ObscuredPrefs.SetString("Shop","On");

	}
	public void GoToLeaderboards()
	{
		Time.timeScale=1;
		ObscuredPrefs.SetString("save","On");
		SceneManager.LoadScene("Leader");
	}
}



