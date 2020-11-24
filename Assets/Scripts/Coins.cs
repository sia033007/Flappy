using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
	public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       anim=GetComponent<Animator>();
       StartCoroutine(coin());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator coin (){
    	yield return new WaitForSeconds (1f);
    	anim.SetInteger ("move",1);
    	yield return new WaitForSeconds (2f);
    	gameObject.SetActive(false);
    	anim.enabled=!anim.enabled;
    }
}
