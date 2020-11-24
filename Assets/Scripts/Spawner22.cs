using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;

public class Spawner22 : MonoBehaviour {

	public float maxTime=1;
	public float Timer = 0;
	public GameObject pipe;
	public float height;



	// Use this for initialization
	void Start () {

		pipe = GameObject.FindGameObjectWithTag ("Rock11");



	}








	// Update is called once per frame
	void Update()
	{

		if (Timer > maxTime)
		{

			GameObject newpipe = Instantiate(pipe);


			newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

			Destroy(newpipe, 15);
			Timer = 0;

		}

		Timer += Time.deltaTime;

	}

}









