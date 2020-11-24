using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;
using UnityEngine.SceneManagement;

public class BonusUI : MonoBehaviour {


	public Text coin_text;
	public Text finalscore;
	public Slider slider;
	public AudioSource[]aud;
	public GameObject audio1;
	public GameObject end;
	public GameObject coin;
	public static int score;
	public GameObject pause1;
	public GameObject warn;
	
	
	void Awake () {
		score=0;
		StartCoroutine(warning());
	}

	void Start () {

		
		StartCoroutine(elapsed());
		UIManager2.coin_score=ObscuredPrefs.GetInt("Score");
	}	

	void Update () {
		coin_text.text = score.ToString ();
		finalscore.text= score.ToString();
		if(slider.value==35){
		    audio1.SetActive(true);
		    StartCoroutine(win());
			ObscuredPrefs.SetInt("Leader",score);		
		}
		else{
			audio1.SetActive(false);
		}
		if(Input.GetKeyDown(KeyCode.Escape)){
			pause1.SetActive(true);
			Time.timeScale=0;
			aud[0].Pause();
		}
	}

	IEnumerator elapsed () {
		yield return new WaitForSeconds (2f);
		slider.value++;
		StartCoroutine (elapsed ());
	}
	public void menu (){
		Time.timeScale=1;
		end.SetActive(false);
		SceneManager.LoadScene("Menu");
	}
	IEnumerator win (){
		yield return new WaitForSeconds (1f);
		end.SetActive(true);
		ObscuredPrefs.SetString ("Bonus","Off");
		ObscuredPrefs.SetString("sysString", System.DateTime.Now.ToBinary().ToString());
		ObscuredPrefs.Save();
		aud[0].Pause();
		Time.timeScale=0;
	}
	public void resume (){
		Time.timeScale=1;
		aud[0].UnPause();
		pause1.SetActive(false);
	}
	public void home (){
		Time.timeScale=1;
		aud[0].UnPause();
		pause1.SetActive(false);
		SceneManager.LoadScene("Menu");
	}
	IEnumerator warning (){
		yield return new WaitForSeconds (1f);
		warn.SetActive(true);
		yield return new WaitForSeconds (4f);
		warn.SetActive(false);
	}
	public void leader(){
		SceneManager.LoadScene("LeaderBoard");
	}
	
}
		
	




























