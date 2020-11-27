using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;

public class Win4 : MonoBehaviour
{
	public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
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
        DBManager.coin+=90;
        DBManager.level+=1;
    }
}
