using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hele8 : MonoBehaviour {

	public float velocity= 1;
	private Rigidbody2D rb;
	private Camshake shake;
	public Slider sliders;
	public GameObject coin;
	public float height=5;
	public Transform tr4;
	public AudioSource[] audios;
	public GameObject bubble;
	public Slider sli;
	public GameObject move;
	public GameObject rocket;
	public float speed=0.75f;
	public GameObject spawn;
	public GameObject pause1,pause2,win;
	
	void Awake () {
		
		rocket.SetActive (true);
		
		
	}


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		shake = GameObject.FindGameObjectWithTag ("shake").GetComponent<Camshake> ();
		sliders = GameObject.FindGameObjectWithTag ("canvas").GetComponent<UIManager10> ().slider1;
		InvokeRepeating ("ins", 2f, 5f);
		sli = GameObject.FindGameObjectWithTag ("canvas").GetComponent<UIManager10> ().slider;
	}

	void Update ()
	{
		if(pause1.activeInHierarchy==true || pause2.activeInHierarchy==true || win.activeInHierarchy==true){
			GetComponent<AudioSource>().Pause();
		}
		else{
			GetComponent<AudioSource>().UnPause();
		}

		
		foreach(Touch t in Input.touches){
			Vector3 pos =Camera.main.ScreenToWorldPoint(t.position);
			if(t.phase == TouchPhase.Began && pos.x>4){
				rb.velocity=Vector2.up*velocity;
			}
		}
		
		StartCoroutine (bub ());

	}

	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.tag == "ger") {
			StartCoroutine (die ());
		}
	}

	IEnumerator die () {
		shake.shake ();
		sliders.value+=speed;
		yield return null;

	}

	void ins () {
		Instantiate (coin, new Vector3 (0, Random.Range (-height, height), 0), transform.rotation);
	}

	

	public void rocke(){
		Instantiate(rocket,tr4.position,transform.rotation);
		audios[0].Play();
		
	}

	

	IEnumerator bub () {
		if (sli.value == 25) {
			bubble.SetActive (true);
			audios[1].Play();
			move.GetComponent<Move> ().speed =22;
			rocket.SetActive(false);
			yield return new WaitForSeconds (15f);
			bubble.SetActive (false);
			rocket.SetActive(true);
			audios[1].Pause();
			spawn.GetComponent<Spawner5>().height=7;
			
		}
	}


}







