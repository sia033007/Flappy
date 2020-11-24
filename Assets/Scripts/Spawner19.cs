using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner19 : MonoBehaviour {

	public float maxTime=1;
	public float Timer = 0;
	public GameObject pipe;
	public float height;
	public int score =0;

	// Use this for initialization
	void Start () {

		pipe = GameObject.FindGameObjectWithTag ("Rock20");







	}

	void OnGUI () {

		GUI.color = Color.black;
		GUILayout.Label ("score: " + score.ToString ());

	}

	// Update is called once per frame
	void Update () {

		if (Timer > maxTime) {

			GameObject newpipe = Instantiate (pipe);
			score++;
			newpipe.transform.position = transform.position + new Vector3(0, Random.Range (-height, height) ,0);

			Destroy (newpipe, 15);
			Timer = 0;

		}

		Timer += Time.deltaTime;

	}
}



