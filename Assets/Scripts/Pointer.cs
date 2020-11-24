using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
	Animator anim;
    // Start is called before the first frame update
    void Start()
    {
    	anim=GetComponent<Animator>();
    	StartCoroutine (point());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator point (){
    	yield return new WaitForSeconds (1f);
    	anim.SetTrigger ("trig1");
    	yield return new WaitForSeconds (2f);
    	anim.SetTrigger ("trig2");
    }
}
