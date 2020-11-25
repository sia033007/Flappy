using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;

public class Edame1 : MonoBehaviour
{
	public AudioSource[] aud;
	public GameObject pause2,table2;
	public Slider slider1;

	void Start (){
	}

   public void edame (){
		if(DBManager.coin>=25){
		   DBManager.coin-=25;
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
