using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Plane192 : MonoBehaviour {

	public float velocity= 1;
	private Rigidbody2D rb;
	private Camshake shake;
	public Slider sliders;
	public GameObject coin;
	public float height=5;
	public Transform tr2;
	public Transform tr3;
	public AudioSource[] audios;
	public GameObject bubble;
	public Slider sli;
	public GameObject move;
	public GameObject fire;
	public float speed=0.25f;
	public GameObject spawn;
	

	
	










	void Awake () {
		
		fire.SetActive (true);
		
		
	}


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		shake = GameObject.FindGameObjectWithTag ("shake").GetComponent<Camshake> ();
		sliders = GameObject.FindGameObjectWithTag ("canvas").GetComponent<UIManager2> ().slider1;
		InvokeRepeating ("ins", 2f, 5f);
		sli = GameObject.FindGameObjectWithTag ("canvas").GetComponent<UIManager2> ().slider;
		






	}

	void Update ()
	{
		
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

	

	public void fir(){
		Instantiate(fire,tr2.position,transform.rotation);
		audios[0].Play();
		

	}

	

	IEnumerator bub () {
		if (sli.value == 25) {
			bubble.SetActive (true);
			audios[1].Play();
			move.GetComponent<Move> ().speed =6;
			fire.SetActive(false);
			yield return new WaitForSeconds (15f);
			fire.SetActive(true);
			bubble.SetActive (false);
			audios[1].Pause();
			spawn.GetComponent<Spawner5>().height=3;
			
		}
	}


}







