using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;

public class Win1 : MonoBehaviour
{
	public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        UIManager2.coin_score=ObscuredPrefs.GetInt("Score");
    }

    // Update is called once per frame
    void Update()
    {
       if(slider.value==80){
       	StartCoroutine (win());

       } 
    }
    IEnumerator win (){
    	yield return new WaitForSeconds(3f);
    	ObscuredPrefs.SetInt("Score",UIManager2.coin_score+=15);
    }
}
