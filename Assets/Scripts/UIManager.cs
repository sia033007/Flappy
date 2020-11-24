using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;

public class UIManager : MonoBehaviour {

	public static ObscuredInt coin_score = 0;

	public Text coin_text;
	public Slider slider;
	public Slider slider1;
	public Slider slider2;
	public GameObject bul;
	public bool reverse;
	public float timer;
	public int delay = 1;
	public float speed=0.5f;
	public GameObject pause;









	void Awake () {
		
		}

	void Start () {
		coin_score = ObscuredPrefs.GetInt ("Score");
		StartCoroutine (elapsed ());
		slider1.minValue = 0;
		slider1.maxValue = 20;
		bul = GameObject.FindGameObjectWithTag ("Player").GetComponent<Plane22> ().bullet;



	




	}

	void Update () {
		timer += Time.deltaTime;
		if (timer >= delay && reverse == false) {
			timer = 0f;
			slider2.value++;
		}

		if (timer >= delay && reverse == true) {
			timer = 0f;
			slider2.value -= speed;


		}

		coin_text.text = coin_score.ToString ();
		ObscuredPrefs.SetInt ("Score", coin_score);

		if (slider2.value == 10) {
			bul.SetActive (false);
			reverse = true;
		}
		
		

		if (slider2.value == 0) {
			bul.SetActive (true);
			reverse = false;
		}
   }



	IEnumerator elapsed () {
		yield return new WaitForSeconds (2f);
		slider.value++;
		StartCoroutine (elapsed ());
	}


}

























