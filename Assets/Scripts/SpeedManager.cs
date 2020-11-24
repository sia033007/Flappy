using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedManager : MonoBehaviour
{
	public GameObject[]bubble;
	public GameObject move;
	public GameObject spawn;
	public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(bubble[0].activeInHierarchy==true || bubble[1].activeInHierarchy==true || bubble[2].activeInHierarchy==true || bubble[3].activeInHierarchy==true || bubble[4].activeInHierarchy==true || bubble[5].activeInHierarchy==true){
       move.GetComponent<Move> ().speed = 17;

       } 
       if(bubble[0].activeInHierarchy==false || bubble[1].activeInHierarchy==false || bubble[2].activeInHierarchy==false || bubble[3].activeInHierarchy==false || bubble[4].activeInHierarchy==false || bubble[5].activeInHierarchy==false && slider.value>25){
       	move.GetComponent<Move> ().speed = 10;
		spawn.GetComponent<Spawner5>().height=5;
       }      
    }
}
