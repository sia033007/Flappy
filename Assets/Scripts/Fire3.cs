using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fire3 : MonoBehaviour
{
    
   
    public Animator anim;

    void Start()
    {
       
       anim=GetComponent<Animator>();    
    }

    void Awake (){
    	
    }

    void OnTriggerEnter2D (Collider2D coli){

		if (coli.tag == "Obstacle" || coli.tag== "ger") {
			Destroy (coli.gameObject);
			gameObject.SetActive(false);
			anim.enabled=!anim.enabled;
		}
	}

    void Update(){
        if(gameObject.activeInHierarchy==true){
            Destroy(gameObject,2f);
        }
    }   
}
