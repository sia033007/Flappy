using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;


public class BonusPlane3 : MonoBehaviour {

	private Rigidbody2D rb;
	public GameObject coin;
	public float height=5;
	public Slider slider;
	public AudioSource aud;
	public GameObject pause1,end;
	float movespeed=40f;
	float dirx;
	float dirx2;
	Animator anim;
	

	void Awake () {
			
	}


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();
		anim=GetComponent<Animator>();
		InvokeRepeating ("ins", 2f, 3f);
		anim.SetFloat ("move",dirx);
		anim.SetFloat("move",dirx2);


	}

	void Update ()
	{
		if(slider.value==25){
		    StartCoroutine (win());
		}
		
		if(pause1.activeInHierarchy==true || end.activeInHierarchy==true){
			GetComponent<AudioSource>().Pause();
		}
		else{
			GetComponent<AudioSource>().UnPause();
		}
	}
	void FixedUpdate (){ 
		dirx=Input.acceleration.x*movespeed;
		dirx2=-Input.acceleration.x*movespeed;
		rb.velocity=new Vector2 (Random.Range(dirx2,dirx),0f);

	}

	void ins () {
		Instantiate (coin, new Vector3 (Random.Range (-height, height),5, 0), transform.rotation);
	}
	IEnumerator win (){
		yield return new WaitForSeconds (1f);
		DBManager.coin+=BonusUI.score;
		gameObject.SetActive(false);
	}
	void OnTriggerEnter2D (Collider2D col){
		if(col.tag == "Coin"){
			aud.Play();
		}	
	}
}








