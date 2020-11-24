using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodeCam5 : MonoBehaviour {





	public GameObject BluePlane;
	public GameObject WhitePlane;
	public GameObject YellowPlane;
	public GameObject WarPlane1;
	public GameObject WarPlane2;
	public GameObject Dragon;

	// Use this for initialization
	void Start () {


		if (MainMenu3.chnum == 1) {

			BluePlane.SetActive (true);
		}

		if (MainMenu3.chnum == 2) {

			WhitePlane.SetActive (true);
		}

		if (MainMenu3.chnum == 3) {

			YellowPlane.SetActive (true);
		}

		if (MainMenu3.chnum == 4) {

			WarPlane1.SetActive (true);
		}

		if (MainMenu3.chnum == 5) {

			WarPlane2.SetActive (true);
		}

		if (MainMenu3.chnum == 6) {

			Dragon.SetActive (true);

		}
	}



	// Update is called once per frame
	void Update () {

	}

}



