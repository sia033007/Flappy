using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {

	public float maxTime=1;
	public float Timer = 0;
	public GameObject rock;
	public float height;
	public int score =0;

	// Use this for initialization
	void Start () {

		GameObject newrock = Instantiate (rock);
		newrock.transform.position= transform.position +new Vector3( 0, Random.Range(-height, height) ,0);


	}

	void OnGUI () {

		GUI.color = Color.black;
		GUILayout.Label ("score: " + score.ToString ());

	}

	// Update is called once per frame
	void Update () {

		if (Timer > maxTime) {

			GameObject newrock = Instantiate (rock);
			score++;
			newrock.transform.position = transform.position + new Vector3(0, Random.Range (-height, height) ,0);

			Destroy (newrock, 15);
			Timer = 0;

		}

		Timer += Time.deltaTime;



	}
}
