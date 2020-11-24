using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBullet1 : MonoBehaviour
{
    // Start is called before the first frame update
   public Rigidbody2D rb;
   public Slider slider;
   public float plane2=1.5f;
   public float plane3=0.75f;
   public float plane4=0.5f;
   public float plane5=0.25f;



	// Use this for initialization
	void Start () {
		rb.velocity = new Vector2 (-2 * 15, 0);
		slider=GameObject.Find("Canvas").GetComponent<UIEnemy2>().slider1;

		}
	
	// Update is called once per frame
	void FixedUpdate () {
	
	}
	void OnTriggerEnter2D (Collider2D col){

		if (col.tag == "Player"){
			Destroy (gameObject);
			if(MainMenu3.chnum==1){
				slider.value+=2;
			}
			if(MainMenu3.chnum==2){
				slider.value+=plane2;
			}
			if(MainMenu3.chnum==3){
				slider.value++;
			}
			if(MainMenu3.chnum==4){
				slider.value+=plane3;
			}
			if(MainMenu3.chnum==5){
				slider.value+=plane4;
			}
			if(MainMenu3.chnum==6){
				slider.value+=plane5;
			}
		}

	}
}

