using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;
public class MainMenu : MonoBehaviour {

	int SceneIndex;
	public GameObject wood;
	public GameObject music;
	public GameObject gift,nogift,bonuslevel;

	void Awake (){
		ObscuredPrefs.GetString("firstplay","yes");
		if(ObscuredPrefs.GetString("firstplay")!="no"){
			gift.SetActive(true);
        	nogift.SetActive(false);
		}
		ObscuredPrefs.SetString("Shop","Off");
		ObscuredPrefs.SetString("save","off");

	}	
	
	void Start () {
		
		music = GameObject.FindGameObjectWithTag ("music");
		if(ObscuredPrefs.GetString("Bonus")=="Off"){
			gift.SetActive(false);
			nogift.SetActive(true);      	
        }
        else if(ObscuredPrefs.GetString("Bonus")=="On" && Date.click==true){
        	gift.SetActive(true);
        	nogift.SetActive(false);
        }
	}



	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Escape)) {
			wood.SetActive (true);
			music.GetComponent<AudioSource> ().Pause ();
		
		
		}
	}

	public void Startgame () {

		SceneManager.LoadScene ("Menu3");



	}

	public void Exitgame () {
		wood.SetActive (true);
		music.GetComponent<AudioSource> ().Pause ();

		}

	public void Shop () {
		SceneManager.LoadScene ("shop");
	}

	public void yes () {
		Application.Quit ();
	}

	public void no () {
		wood.SetActive (false);
		music.GetComponent<AudioSource> ().UnPause ();
		
	}

	public void Rahnama () {
		SceneManager.LoadScene ("rahnama");
	}

	public void Tamas () {
		SceneManager.LoadScene ("tamas");
	}
	public void Bonus () {
		SceneManager.LoadScene(Random.Range(23,28));
	}
	public void GoToScoreBoard()
	{
		SceneManager.LoadScene("Leader");
	}
	public void RateUs(){
		AndroidJavaClass intentClass = new AndroidJavaClass ("android.content.Intent");
AndroidJavaObject intentObject = new AndroidJavaObject ("android.content.Intent");
 
AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
 
intentObject.Call<AndroidJavaObject> ("setAction", intentClass.GetStatic<string> ("ACTION_EDIT"));
intentObject.Call<AndroidJavaObject> ("setData", uriClass.CallStatic<AndroidJavaObject>("parse","bazaar://details?id=com.Gameone.Tayyare"));
intentObject.Call<AndroidJavaObject>("setPackage", "com.farsitel.bazaar");
 
AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
currentActivity.Call ("startActivity", intentObject);
	}
	IEnumerator bon (){
		yield return new WaitForSeconds (1f);
		bonuslevel.SetActive(true);
		yield return new WaitForSeconds (5f);
		bonuslevel.SetActive(false);
	}
	public void bonuses (){
		StartCoroutine (bon());
	}
	void OnApplicationFocus(bool focus)
     {
     	if(!focus){
     		ObscuredPrefs.SetString ("Bonus","On");
     	    ObscuredPrefs.Save();  
     	}
     	else{
     		ObscuredPrefs.SetString("firstplay","no");
     		ObscuredPrefs.Save();
     	}
     	     
     }
     void OnApplicationPause(bool pauseStatus){
     	if(pauseStatus){
     		ObscuredPrefs.SetString ("Bonus","On");
     	    ObscuredPrefs.Save(); 
     	}
     	else{
     		ObscuredPrefs.SetString("firstplay","no");
     		ObscuredPrefs.Save();
     	}

     }   
}


