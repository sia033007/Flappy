using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Explosion : MonoBehaviour
{
	public Slider slider1;
	public Slider slider2;
	public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      if(slider1.value==80){
      	StartCoroutine (die());
      }
      if(slider2.value==80){
      	StartCoroutine(die());
      }  
    }
   IEnumerator die (){
   	anim.enabled=true;
   	yield return new WaitForSeconds (3f);
   	gameObject.SetActive (false);
   	anim.enabled=! anim.enabled;

   }
   public void end (){
    SceneManager.LoadScene ("End");
    Time.timeScale=1;
   }
}
