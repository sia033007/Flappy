using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sorme4 : MonoBehaviour {

	public float velocity= 1;
	private Rigidbody2D rb;
	private Camshake shake;
	public Slider sliders;
	public GameObject coin;
	public float height=5;
	public Transform tr6;
	public AudioSource[] audios;
	public GameObject bubble;
	public Slider sli;
	public GameObject move;
	public GameObject bullet;
	public float speed=1.5f;
	public GameObject spawn;
	

	
	










	void Awake () {
		
		bullet.SetActive (true);
		
		
	}


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		shake = GameObject.FindGameObjectWithTag ("shake").GetComponent<Camshake> ();
		sliders = GameObject.FindGameObjectWithTag ("canvas").GetComponent<UIManager6> ().slider1;
		InvokeRepeating ("ins", 2f, 5f);
		sli = GameObject.FindGameObjectWithTag ("canvas").GetComponent<UIManager6> ().slider;
		






	}

	void Update ()
	{

		foreach(Touch t in Input.touches){
			Vector3 pos =Camera.main.ScreenToWorldPoint(t.position);
			if(t.phase == TouchPhase.Began && pos.x>4){
				rb.velocity=Vector2.up*velocity;
				audios[2].Play();
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

	

	public void bulle(){
		Instantiate(bullet,tr6.position,transform.rotation);
		audios[0].Play();
		
	}

	

	IEnumerator bub () {
		if (sli.value == 25) {
			bubble.SetActive (true);
			audios[1].Play();
			move.GetComponent<Move> ().speed =14;
			bullet.SetActive(false);
			yield return new WaitForSeconds (15f);
			bubble.SetActive (false);
			audios[1].Pause();
			spawn.GetComponent<Spawner5>().height=5;
			
		}
	}


}







