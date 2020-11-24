using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
	public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
      anim=GetComponent<Animator>();
      StartCoroutine(but());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator but (){
    	yield return new WaitForSeconds (1f);
    	anim.SetInteger ("move",1);
    	yield return new WaitForSeconds (3f);
    	anim.SetInteger ("move",2);
    	StartCoroutine (but());
    }
}
