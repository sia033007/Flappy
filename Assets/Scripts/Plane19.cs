using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Plane19 : MonoBehaviour {

	public float velocity= 1;
	private Rigidbody2D rb;
	private Camshake shake;
	public Slider sliders;
	public GameObject coin;
	public float height=5;
	public GameObject bullet;
	public Transform[] bul = new Transform[6];
	public int numberbul=0;
	public AudioSource[] audios;
	public GameObject[] bubble = new GameObject[6];
	public Slider sli;
	public GameObject move;
	public GameObject pause;
	public GameObject fire;
	public GameObject rocket;

	
	










	void Awake () {
		bullet.SetActive (true);
		fire.SetActive (true);
		rocket.SetActive(true);
		
	}


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		shake = GameObject.FindGameObjectWithTag ("shake").GetComponent<Camshake> ();
		sliders = GameObject.FindGameObjectWithTag ("canvas").GetComponent<UIManager2> ().slider1;
		InvokeRepeating ("ins", 2f, 5f);
		bul[0] = GameObject.FindGameObjectWithTag ("bul").GetComponent<Transform> ();
		bul[1]= GameObject.Find("bul1").GetComponent<Transform> ();
		bul[2]= GameObject.Find("Fire3").GetComponent<Transform>();
		audios [0] = GameObject.Find ("audio1").GetComponent<AudioSource> ();
		audios [1] = GameObject.Find ("audio2").GetComponent<AudioSource> ();
		audios [2] = GameObject.Find ("audio3").GetComponent<AudioSource> ();
		sli = GameObject.FindGameObjectWithTag ("canvas").GetComponent<UIManager2> ().slider;






	}

	void Update ()
	{

		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0) {
			pause.GetComponent<UIManager2>().di();

		}



		if(Input.GetMouseButtonDown(0)){
			rb.velocity=Vector2.up*velocity;
			audios[4].Play();
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
		sliders.value++;
		yield return null;

	}

	void ins () {
		Instantiate (coin, new Vector3 (0, Random.Range (-height, height), 0), transform.rotation);
	}

	public void bull() {
		Instantiate (bullet, bul[1].position,transform.rotation);
		audios [1].Play ();
	}

	public void fir(){
		Instantiate(fire,bul[2].position,transform.rotation);
		audios[3].Play();


	}

	public void rock(){
		Instantiate(rocket,bul[3].position,transform.rotation);
		audios [1].Play ();
	}

	



	



	IEnumerator bub () {
		if (sli.value == 20) {
			bubble[1].SetActive (true);
			move.GetComponent<Move> ().speed = 17;
			audios [2].Play ();
			audios[4].Pause();
			bullet.SetActive (false);
			fire.SetActive(false);
			rocket.SetActive(false);
			yield return new WaitForSeconds (15f);
			bubble[1].SetActive (false);
			move.GetComponent<Move> ().speed = 10;
			audios [2].Pause ();
			audios[4].UnPause();

		}
	}


}







