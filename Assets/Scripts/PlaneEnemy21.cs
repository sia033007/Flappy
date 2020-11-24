using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneEnemy21 : MonoBehaviour
{
    // Start is called before the first frame update
   public float velocity= 1;
	private Rigidbody2D rb;
	private Camshake shake;
	public Slider slider1;
	public Transform tr2;
	public AudioSource[] audios;
	public GameObject fire;
	public float speed=0.25f;

	

	void Awake () {
		
		fire.SetActive (true);
		
		
	}


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		shake = GameObject.FindGameObjectWithTag ("shake").GetComponent<Camshake> ();
		slider1 = GameObject.FindGameObjectWithTag ("canvas").GetComponent<UIEnemy1> ().slider1;
		
	}

	void Update ()
	{
		foreach(Touch t in Input.touches){
			Vector3 pos =Camera.main.ScreenToWorldPoint(t.position);
			if(t.phase ==TouchPhase.Moved && pos.x>0 && pos.x <3){
				rb.velocity=new Vector2(2*60*Time.deltaTime,0);
			}
			if(t.phase==TouchPhase.Moved && pos.x<0 && pos.x>-3){
				rb.velocity=new Vector2(-2*60*Time.deltaTime,0);
			}
			if(t.phase == TouchPhase.Began && pos.x>4){
				rb.velocity=Vector2.up*velocity;	
			}
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
	

	public void fir(){
		Instantiate(fire,tr2.position,transform.rotation);
		audios[0].Play();
		

	}

}




