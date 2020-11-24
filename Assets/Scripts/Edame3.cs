using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;


public class Edame3 : MonoBehaviour
{
	public AudioSource[] aud;
	public GameObject pause2,table2;
	public Slider slider1;

	void Start (){
		UIManager2.coin_score=ObscuredPrefs.GetInt("Score");
	}

   public void edame (){
		if(UIManager2.coin_score>=70){
		   ObscuredPrefs.SetInt ("Score", UIManager2.coin_score-=70);
		   slider1.value=0;
		   aud[0].UnPause();
		   aud[1].UnPause();
		   Time.timeScale=1;
		   pause2.SetActive(false);

		}
		else{
			
			StartCoroutine(table());
		}	
	}
	IEnumerator table (){
		yield return new WaitForSecondsRealtime (1f);
		table2.SetActive(true);
		yield return new WaitForSecondsRealtime (4f);
		table2.SetActive(false);
	}
}
