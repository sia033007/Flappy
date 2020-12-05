using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bulb : MonoBehaviour
{
    public GameObject internetWarn;
    public Image image;
   
	public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
      image = GetComponent<Image>();
      anim=GetComponent<Animator>();
      StartCoroutine(but());
      StartCoroutine(ChangeColor());

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
    IEnumerator ChangeColor()
    {
        yield return new WaitForSeconds(1f);
        image.color = Color.yellow;
        yield return new WaitForSeconds(1f);
        image.color = Color.red;
        StartCoroutine(ChangeColor());
    }
    IEnumerator warn()
    {
        internetWarn.SetActive(true);
        yield return new WaitForSeconds(5f);
        internetWarn.SetActive(false);
    }
    public void Warnings()
    {
        StartCoroutine(warn());
    }
    
}
