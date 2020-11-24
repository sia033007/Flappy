using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;

public class Spawner8 : MonoBehaviour {

	public float maxTime=1;
	public float Timer = 0;
	public GameObject pipe;
	public float height;
	public Text score;
	private ObscuredInt number;
	public Text HighScore;


	// Use this for initialization
	void Start () {

		pipe = GameObject.FindGameObjectWithTag ("Rock8");
		HighScore.text = ObscuredPrefs.GetInt ("HighScore", 0).ToString ();


	}

	void OnGUI () {


		score.text = ("Score :" + number.ToString ());
		if (number > ObscuredPrefs.GetInt ("HighScore", 0)) {
			ObscuredPrefs.SetInt ("HighScore", number);
			HighScore.text = ("HighScore :" + number.ToString ());
		}




	}


	// Update is called once per frame
	void Update () {

		if (Timer > maxTime) {

			GameObject newpipe = Instantiate (pipe);

			if (UIManager2.coin_score<= number || UIManager2.coin_score==number || UIManager2.coin_score>= number) {

				number++;
				if (number == 40) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}

				if (number == 80) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}

				if (number == 120) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}

				if (number == 160) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}

				if (number == 200) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}

				if (number == 240) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}

				if (number == 280) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}

				if (number == 320) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}

				if (number == 360) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}

				if (number == 400) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}

				if (number == 440) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}

				if (number == 480) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}

				if (number == 520) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}

				if (number == 560) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}

				if (number == 600) {

					UIManager2.coin_score++;
					GetComponent<AudioSource> ().Play ();
				}
			}

			newpipe.transform.position = transform.position + new Vector3(0, Random.Range (-height, height) ,0);

			Destroy (newpipe, 15);
			Timer = 0;

		}

		Timer += Time.deltaTime;


	}
}









