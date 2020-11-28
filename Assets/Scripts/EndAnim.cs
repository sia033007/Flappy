using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndAnim : MonoBehaviour
{
	public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       anim=GetComponent<Animator>();
       StartCoroutine(ghool()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ghool (){
		yield return new WaitForSeconds (3f);
		anim.SetTrigger ("trig1");
		yield return new WaitForSeconds (3f);
		anim.SetTrigger ("trig2");

		StartCoroutine (ghool());
	}
	public void RateUs()
	{
		Application.OpenURL("bazaar://details?id=com.Gameone.Tayyare");
	}
	public void home(){
		SceneManager.LoadScene ("Menu");
	}
}
