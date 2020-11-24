using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneEnemy4 : MonoBehaviour
{
    // Start is called before the first frame update
   public float velocity= 1;
	private Rigidbody2D rb;
	private Camshake shake;
	public Slider slider1;
	public Transform tr4;
	public AudioSource[] audios;
	public GameObject rocket;
	public float speed=0.75f;
	public GameObject win,pause1,pause2;
	
	void Awake () {
		
		rocket.SetActive (true);
		
		
	}


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		shake = GameObject.FindGameObjectWithTag ("shake").GetComponent<Camshake> ();
		slider1 = GameObject.FindGameObjectWithTag ("canvas").GetComponent<UIEnemy2> ().slider1;
	}

	void Update ()
	{

		
		foreach(Touch t in Input.touches){
			Vector3 pos =Camera.main.ScreenToWorldPoint(t.position);
			if(t.phase == TouchPhase.Began && pos.x>4){
				rb.velocity=Vector2.up*velocity;
			}
		}

		if(win.activeInHierarchy==true || pause2.activeInHierarchy==true || pause1.activeInHierarchy==true){
			GetComponent<AudioSource>().Pause();
		}
		else{
			GetComponent<AudioSource>().UnPause();
		}

		

	}

	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.tag == "ger") {
			StartCoroutine (die ());
		}
	}

	IEnumerator die () {
		shake.shake ();
		slider1.value+=speed;
		yield return null;

	}

	public void rocke(){
		Instantiate(rocket,tr4.position,transform.rotation);
		audios[0].Play();
		
	}

}







