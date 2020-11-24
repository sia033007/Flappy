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
	public void RateUs(){
		AndroidJavaClass intentClass = new AndroidJavaClass ("android.content.Intent");
AndroidJavaObject intentObject = new AndroidJavaObject ("android.content.Intent");
 
AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
 
intentObject.Call<AndroidJavaObject> ("setAction", intentClass.GetStatic<string> ("ACTION_EDIT"));
intentObject.Call<AndroidJavaObject> ("setData", uriClass.CallStatic<AndroidJavaObject>("parse","bazaar://details?id=com.Gameone.Tayyare"));
intentObject.Call<AndroidJavaObject>("setPackage", "com.farsitel.bazaar");
 
AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
currentActivity.Call ("startActivity", intentObject);
	}
	public void home(){
		SceneManager.LoadScene ("Menu");
	}
}
