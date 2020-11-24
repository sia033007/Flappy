using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;


public class MainMenu3 : MonoBehaviour {

	[SerializeField] Button BluePlane;
	[SerializeField] Button Plane2;
	[SerializeField] GameObject wood1;
	[SerializeField] Button Plane3;
	[SerializeField] GameObject wood2;
	[SerializeField] GameObject wood3;
	[SerializeField] Button Plane4;
	[SerializeField] Button Plane5;
	[SerializeField] GameObject wood4;
	[SerializeField] Button Dragon;
	[SerializeField] GameObject wood5;



	public static ObscuredInt chnum;
	public ObscuredBool isPlanesold;
	public GameObject frame1,frame2,frame3,frame4,frame5;
	



void Start () {
		
		ObscuredPrefs.SetString ("BluePlane", "on");
		if (ObscuredPrefs.GetString ("Plane2") == "on") {
			wood1.SetActive (false);
		}
		if (ObscuredPrefs.GetString ("Plane3") == "on") {
			wood2.SetActive (false);
		}
		if (ObscuredPrefs.GetString ("Plane4") == "on") {
			wood3.SetActive (false);
		}
		if (ObscuredPrefs.GetString ("Plane5") == "on") {
			wood4.SetActive (false);
		}
		if (ObscuredPrefs.GetString ("Dragon") == "on") {
			wood5.SetActive (false);
		}

	
		UIManager2.coin_score = ObscuredPrefs.GetInt ("Score");
		isPlanesold = ObscuredPrefs.GetInt ("isPlanesold") == 0 ? false:true;

	


		}


	public void Blueplane () {

	
		chnum = 1;
	
		ObscuredPrefs.Save ();
		SceneManager.LoadScene ("Menu5");
	}

	public void BuyPlane2 () {

		if (ObscuredPrefs.GetString ("Plane2") == "on") { 
			ObscuredPrefs.SetInt ("isPlanesold", 1);
		    chnum = 2;
			ObscuredPrefs.Save ();
			SceneManager.LoadScene ("Menu5");
		} else if (UIManager2.coin_score >=60) {
			ObscuredPrefs.SetInt ("isPlanesold", 1);
			chnum = 2;
			ObscuredPrefs.SetInt ("Score", UIManager2.coin_score-=60);
			ObscuredPrefs.Save ();
			ObscuredPrefs.SetString ("Plane2", "on");
			SceneManager.LoadScene ("Menu5");

			}
		else 
		{
			Debug.Log ("You Don't Have The Score");
		
		}


	}

	public void BuyPlane3 () {

		if (ObscuredPrefs.GetString ("Plane3") == "on") { 
			ObscuredPrefs.SetInt ("isPlanesold", 1);
			chnum = 3;
			ObscuredPrefs.Save ();
			SceneManager.LoadScene ("Menu5");
		} else if (UIManager2.coin_score >=120) {
			ObscuredPrefs.SetInt ("isPlanesold", 1);
			chnum = 3;
			ObscuredPrefs.SetInt ("Score", UIManager2.coin_score-=120);
			ObscuredPrefs.Save ();
			ObscuredPrefs.SetString ("Plane3", "on");
			SceneManager.LoadScene ("Menu5");

		}
		else 
		{
			Debug.Log ("You Don't Have The Score");

		}


	}


	public void BuyPlane4 () {

		if (ObscuredPrefs.GetString ("Plane4") == "on") { 
			ObscuredPrefs.SetInt ("isPlanesold", 1);
			chnum = 4;
			ObscuredPrefs.Save ();
			SceneManager.LoadScene ("Menu5");
		} else if (UIManager2.coin_score >=180) {
			ObscuredPrefs.SetInt ("isPlanesold", 1);
		    chnum = 4;
			ObscuredPrefs.SetInt ("Score", UIManager2.coin_score-=180);
			ObscuredPrefs.Save ();
			ObscuredPrefs.SetString ("Plane4", "on");
			SceneManager.LoadScene ("Menu5");

		}
		else 
		{
			Debug.Log ("You Don't Have The Score");

		}


	}

	public void BuyPlane5 () {

		if (ObscuredPrefs.GetString ("Plane5") == "on") { 
			ObscuredPrefs.SetInt ("isPlanesold", 1);
            chnum = 5;
			ObscuredPrefs.Save ();
			SceneManager.LoadScene ("Menu5");
		} else if (UIManager2.coin_score >=240) {
			ObscuredPrefs.SetInt ("isPlanesold", 1);
		    chnum = 5;
			ObscuredPrefs.SetInt ("Score", UIManager2.coin_score-=240);
			ObscuredPrefs.Save ();
			ObscuredPrefs.SetString ("Plane5", "on");
			SceneManager.LoadScene ("Menu5");

		}
		else 
		{
			Debug.Log ("You Don't Have The Score");

		}


	}
	public void BuyDragon () {

		if (ObscuredPrefs.GetString ("Dragon") == "on") { 
			ObscuredPrefs.SetInt ("isPlanesold", 1);
			chnum = 6;
			ObscuredPrefs.Save ();
			SceneManager.LoadScene ("Menu5");
		} else if (UIManager2.coin_score >=300) {
			ObscuredPrefs.SetInt ("isPlanesold", 1);
			chnum = 6;
			ObscuredPrefs.SetInt ("Score", UIManager2.coin_score-=300);
			ObscuredPrefs.Save ();
			ObscuredPrefs.SetString ("Dragon", "on");
			SceneManager.LoadScene ("Menu5");

		}
		else 
		{
			Debug.Log ("You Don't Have The Score");

		}


	}
	


	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
		
		}

		IEnumerator fr1(){
			yield return new WaitForSeconds (1f);
			frame1.SetActive(true);
			yield return new WaitForSeconds (3f);
			frame1.SetActive(false);
		}

		IEnumerator fr2(){
			yield return new WaitForSeconds (1f);
			frame2.SetActive(true);
			yield return new WaitForSeconds (3f);
			frame2.SetActive(false);
		}

		IEnumerator fr3(){
			yield return new WaitForSeconds (1f);
			frame3.SetActive(true);
			yield return new WaitForSeconds (3f);
			frame3.SetActive(false);
		}

		IEnumerator fr4(){
			yield return new WaitForSeconds (1f);
			frame4.SetActive(true);
			yield return new WaitForSeconds (3f);
			frame4.SetActive(false);
		}

		IEnumerator fr5(){
			yield return new WaitForSeconds (1f);
			frame5.SetActive(true);
			yield return new WaitForSeconds (3f);
			frame5.SetActive(false);
		}

		public void fram1(){
			StartCoroutine (fr1());
		}
		public void fram2(){
			StartCoroutine (fr2());
		}
		public void fram3(){
			StartCoroutine (fr3());
		}
		public void fram4(){
			StartCoroutine (fr4());
		}
		public void fram5(){
			StartCoroutine (fr5());

		}


			
}












	


	





		
		











	








