using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;



public class MainMenu4 : MonoBehaviour {

	[SerializeField] Button Level1;
	[SerializeField] Button Level2;
	[SerializeField] GameObject lock1;
	[SerializeField] Button Level3;
	[SerializeField] GameObject lock2;
	[SerializeField] GameObject lock3;
	[SerializeField] Button Level4;




	int SceneIndex;
	public ObscuredBool isLevelsold;



	// Use this for initialization
	void Start (){
		ObscuredPrefs.SetString ("Level1", "on");
		if (ObscuredPrefs.GetString ("Level2") == "on") {
			lock1.SetActive (false);
		}
		if (ObscuredPrefs.GetString ("Level3") == "on") {
			lock2.SetActive (false);
		}
		if (ObscuredPrefs.GetString ("Level4") == "on") {
			lock3.SetActive (false);
		}

		UIManager2.coin_score = ObscuredPrefs.GetInt ("Score");
		isLevelsold = ObscuredPrefs.GetInt ("isLevelsold") == 0 ? false:true;


		SceneIndex = SceneManager.GetActiveScene ().buildIndex;


	}

	public void BuyLevel1 ()
	{


		if (MainMenu2.mode_number == 1) {

			SceneManager.LoadScene ("Plane22");
		}

		if (MainMenu2.mode_number == 2) {

			SceneManager.LoadScene ("Plane222");
		}
	}

	public void BuyLevel2 ()
	{


		if (ObscuredPrefs.GetString ("Level2") == "on") { 
			ObscuredPrefs.SetInt ("isLevelsold", 1);
			ObscuredPrefs.Save ();
			if (MainMenu2.mode_number == 1) {

				SceneManager.LoadScene ("Planelevel2");
			}

			if (MainMenu2.mode_number == 2) {

				SceneManager.LoadScene ("Planelevel22");
			}
		} else if (UIManager2.coin_score >= 20) {
			ObscuredPrefs.SetInt ("isLevelsold", 1);
			ObscuredPrefs.SetInt ("Score", UIManager2.coin_score-=20);
			ObscuredPrefs.SetInt ("Score", UIManager2.coin_score);
			ObscuredPrefs.Save ();
			ObscuredPrefs.SetString ("Level2", "on");
			if (MainMenu2.mode_number == 1) {

				SceneManager.LoadScene ("Planelevel2");
			}

			if (MainMenu2.mode_number == 2) {

				SceneManager.LoadScene ("Planelevel22");
			}

		} else {
			Debug.Log ("You Don't Have The Score");

		}
	}

	public void BuyLevel3 () {

	
		if (ObscuredPrefs.GetString ("Level3") == "on") { 
			ObscuredPrefs.SetInt ("isLevelsold", 1);
			ObscuredPrefs.Save ();
				if (MainMenu2.mode_number == 1) {

					SceneManager.LoadScene ("Planelevel3");
				}

				if (MainMenu2.mode_number==2) {

					SceneManager.LoadScene ("Planelevel32");
				}
			} else if (UIManager2.coin_score >= 40) {
			ObscuredPrefs.SetInt ("isLevelsold", 1);
			ObscuredPrefs.SetInt ("Score", UIManager2.coin_score-=40);
			ObscuredPrefs.SetInt ("Score", UIManager2.coin_score);
			ObscuredPrefs.Save ();
			ObscuredPrefs.SetString ("Level3", "on");
				if (MainMenu2.mode_number == 1) {

					SceneManager.LoadScene ("Planelevel3");
				}

				if (MainMenu2.mode_number==2) {

					SceneManager.LoadScene ("Planelevel32");
				}

			}
			else 
			{
				Debug.Log ("You Don't Have The Score");

			}

		}

	public void BuyLevel4 () {


		if (ObscuredPrefs.GetString ("Level4") == "on") { 
			ObscuredPrefs.SetInt ("isLevelsold", 1);
			ObscuredPrefs.Save ();
				if (MainMenu2.mode_number == 1) {

					SceneManager.LoadScene ("Planelevel4");
				}

				if (MainMenu2.mode_number==2) {

					SceneManager.LoadScene ("Planelevel42");
				}
			} else if (UIManager2.coin_score >= 60) {
			ObscuredPrefs.SetInt ("isLevelsold", 1);
			ObscuredPrefs.SetInt ("Score", UIManager2.coin_score-=60);
			ObscuredPrefs.SetInt ("Score", UIManager2.coin_score);
			ObscuredPrefs.Save ();
			ObscuredPrefs.SetString ("Level4", "on");
				if (MainMenu2.mode_number == 1) {

					SceneManager.LoadScene ("Planelevel4");
				}

				if (MainMenu2.mode_number==2) {

					SceneManager.LoadScene ("Planelevel42");
				}

			}
			else 
			{
				Debug.Log ("You Don't Have The Score");

			}

		}




       void Update () {
		
		if (Input.GetKeyDown (KeyCode.Escape))
			SceneManager.LoadScene (SceneIndex - 1);
		
		
	    }
}









