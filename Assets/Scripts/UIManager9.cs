using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;
using UnityEngine.SceneManagement;

public class UIManager9 : MonoBehaviour {


	public Text coin_text;
	public Slider slider;
	public Slider slider1;
	public Slider slider2;
	public GameObject pref1;
	public GameObject pref2;
	public GameObject pref3;
	public GameObject pref4;
	public bool reverse;
	public float timer;
	public int delay = 1;
	public float speed=0.25f;
	public float speed2=0.5f;
	public float speed3=0.75f;
    public float speed4=1.5f;
    public float speed5=0.1f;
	public GameObject pause1;
	public GameObject pause2;
	public AudioSource[]aud;
	public GameObject audio;
	public GameObject audio2;
	public GameObject audio3;
	public GameObject win;
	public GameObject table;
	public GameObject coin;
	public GameObject but1,but2,but3,but4,but5,but6;
	
	
	










	void Awake () {


	}

	void Start () {
		UIManager2.coin_score = ObscuredPrefs.GetInt ("Score");
		StartCoroutine (elapsed ());
		slider1.minValue = 0;
		slider1.maxValue = 20;

		if (MainMenu3.chnum == 1) {

			but1.SetActive (true);
		}

		if (MainMenu3.chnum == 2) {

			but2.SetActive (true);
		}

		if (MainMenu3.chnum == 3) {

			but3.SetActive (true);
		}

		if (MainMenu3.chnum == 4) {

			but4.SetActive (true);
		}

		if (MainMenu3.chnum == 5) {

			but5.SetActive (true);
		}

		if (MainMenu3.chnum == 6) {

			but6.SetActive (true);

		}

	}

	void Update () {
		timer += Time.deltaTime;

		if(MainMenu3.chnum==1){

		if (timer >= delay && reverse == false) {
			timer = 0f;
			slider2.value++;
		}

		if (timer >= delay && reverse == true) {
			timer = 0f;
			slider2.value -= speed;
			}
		}

		if(MainMenu3.chnum==2){

		if (timer >= delay && reverse == false) {
			timer = 0f;
			slider2.value+=speed3;
		}

		if (timer >= delay && reverse == true) {
			timer = 0f;
			slider2.value -= speed2;
			}
		}

		if(MainMenu3.chnum==3){

		if (timer >= delay && reverse == false) {
			timer = 0f;
			slider2.value+=speed2;
		}

		if (timer >= delay && reverse == true) {
			timer = 0f;
			slider2.value -= speed3;
			}
		}

		if(MainMenu3.chnum==4){

		if (timer >= delay && reverse == false) {
			timer = 0f;
			slider2.value+=speed;
		}

		if (timer >= delay && reverse == true) {
			timer = 0f;
			slider2.value --;
			}
		}

		if(MainMenu3.chnum==5){

		if (timer >= delay && reverse == false) {
			timer = 0f;
			slider2.value+=speed5;
		}

		if (timer >= delay && reverse == true) {
			timer = 0f;
			slider2.value -=speed4;
			}
		}


		coin_text.text = UIManager2.coin_score.ToString ();
		ObscuredPrefs.SetInt ("Score", UIManager2.coin_score);

		if (slider2.value == 10) {
			pref1.SetActive (false);
			reverse = true;
		}



		if (slider2.value == 0) {
			pref1.SetActive (true);
			reverse = false;
		}

		if (slider2.value == 10) {
			pref2.SetActive (false);
			reverse = true;
		}



		if (slider2.value == 0) {
			pref2.SetActive (true);
			reverse = false;
		}

		if (slider2.value == 10) {
			pref3.SetActive (false);
			reverse = true;
		}



		if (slider2.value == 0) {
			pref3.SetActive (true);
			reverse = false;
		}

		if (slider2.value == 10) {
			pref4.SetActive (false);
			reverse = true;
		}



		if (slider2.value == 0) {
			pref4.SetActive (true);
			reverse = false;
		}

		if(slider.value==50){
			coin.SetActive(true);
			StartCoroutine(wins());
		}

		if(slider1.value==20){
			di();
			audio.SetActive(true);	
		}
		else{
			audio.SetActive(false);
		}
		if(coin.activeInHierarchy==true){
			audio3.SetActive(true);
		}
		else{
			audio3.SetActive(false);
		}
	
	}

	public void di(){
		pause2.SetActive(true);
		Time.timeScale = 0;
        aud[0].Pause();
        
     
		
		

	}

	public void but(){
		
		if(slider.value<=25){
			if(UIManager2.coin_score>=75){
				pause2.SetActive(false);
		        Time.timeScale=1;
		        aud[0].UnPause();
		        slider1.value=0;
		       ObscuredPrefs.SetInt("Score",UIManager2.coin_score-=75);
			}
			else {
				StartCoroutine(tabl());
			}
			
		}
		if(slider.value>25){
			if(UIManager2.coin_score>=80){
				pause2.SetActive(false);
		        Time.timeScale=1;
		        aud[0].UnPause();
                slider1.value=0;
		        ObscuredPrefs.SetInt("Score",UIManager2.coin_score-=80);

			}
			else{
				StartCoroutine(tabl());
			}			
		}
	}

	IEnumerator elapsed () {
		yield return new WaitForSeconds (2f);
		slider.value++;
		StartCoroutine (elapsed ());
	}
	IEnumerator tabl (){
		yield return new WaitForSecondsRealtime (1f);
		table.SetActive(true);
		yield return new WaitForSecondsRealtime (3f);
		table.SetActive(false);
	}
	IEnumerator wins (){
		yield return new WaitForSeconds (3f);
		win.SetActive(true);
		aud[0].Pause();
		audio2.SetActive(true);
		coin.SetActive(false);
		Time.timeScale=0;
		yield return new WaitForSecondsRealtime(1f);
		if(ObscuredPrefs.GetString("played8")!="On"){
			ObscuredPrefs.SetInt("Score",UIManager2.coin_score+=25);
		}
		yield return new WaitForSecondsRealtime (0.2f);
		ObscuredPrefs.SetString ("played8","On");

	}
	

	
}
		
	




























