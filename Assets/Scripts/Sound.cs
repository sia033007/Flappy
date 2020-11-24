using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sound : MonoBehaviour {

	public GameObject gamemusic;


		void Awake ()
		{
			GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
			if (objs.Length > 1)
				Destroy(this.gameObject);

			DontDestroyOnLoad(this.gameObject);

		}

		void Update()
		{
		if (SceneManager.GetActiveScene().name == "Knight1")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Knight2")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Western1")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Western2")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Chris1")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Chris2")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Sea1")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Sea2")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Factory1")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Factory2")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Enemy1")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Enemy2")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Enemy3")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Enemy4")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Enemy5")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Bonus1")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Bonus2")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Bonus3")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Bonus4")
		{
			Destroy(this.gameObject);
		}
		if (SceneManager.GetActiveScene().name == "Bonus5")
		{
			Destroy(this.gameObject);
		}
		}
	}









			








