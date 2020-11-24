using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Plane22 : MonoBehaviour {

	public float velocity= 1;
	private Rigidbody2D rb;
	private Camshake shake;
	public Slider sliders;
	public GameObject coin;
	public float height=5;
	public GameObject bullet;
	public Transform bul;
	public int numberbul=0;
	public AudioSource[] audios;
	public GameObject bubble;
	public Slider sli;
	public GameObject move;









	void Awake () {
		bullet.SetActive (true);
	}


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		shake = GameObject.FindGameObjectWithTag ("shake").GetComponent<Camshake> ();
		sliders = GameObject.FindGameObjectWithTag ("canvas").GetComponent<UIManager> ().slider1;
		InvokeRepeating ("ins", 2f, 5f);
		bul = GameObject.FindGameObjectWithTag ("bul").GetComponent<Transform> ();
		audios [0] = GameObject.Find ("audio1").GetComponent<AudioSource> ();
		audios [1] = GameObject.Find ("audio2").GetComponent<AudioSource> ();
		audios [2] = GameObject.Find ("audio3").GetComponent<AudioSource> ();
		sli = GameObject.FindGameObjectWithTag ("canvas").GetComponent<UIManager> ().slider;

	



		}

	void Update () {

		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if(screenPosition.y>Screen.height || screenPosition.y<0){
			SceneManager.LoadScene ("Planelevel22");
	}



		if (Input.GetMouseButtonDown (0)) {
			rb.velocity = Vector2.up * velocity;
		}
			



			StartCoroutine (bub ());

		}

	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.tag == "Obstacle") {
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
		Instantiate (bullet, bul.position,transform.rotation);
		audios [1].Play ();
	}



	IEnumerator bub () {
		if (sli.value == 20) {
			bubble.SetActive (true);
			move.GetComponent<Move> ().speed = 17;
			audios [2].Play ();
			bullet.SetActive (false);
			yield return new WaitForSeconds (15f);
			bubble.SetActive (false);
			move.GetComponent<Move> ().speed = 10;
			audios [2].Pause ();

		}
	}


}







