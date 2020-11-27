using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;


public class MainMenu3 : MonoBehaviour {

	[SerializeField] Button BluePlane;
	[SerializeField] Button Plane2;
	[SerializeField] GameObject wood1;
	[SerializeField] Button Plane3;
	[SerializeField] GameObject wood2;
	[SerializeField] GameObject wood3;
	[SerializeField] Button Plane4;
	[SerializeField] Button Plane5;
	[SerializeField] GameObject wood4;
	[SerializeField] Button Dragon;
	[SerializeField] GameObject wood5;



	public static ObscuredInt chnum;
	public ObscuredBool isPlanesold;
	public GameObject frame1,frame2,frame3,frame4,frame5;
	



void Start ()
{
	if(DBManager.planetwo ==1)
	{
		wood1.SetActive(false);
	}
	else if(DBManager.planethree ==1)
	{
		wood2.SetActive(false);
	}
	else if(DBManager.planefour ==1)
	{
		wood3.SetActive(false);
	}
	else if(DBManager.planefive ==1)
	{
		wood4.SetActive(false);
	}
	else if(DBManager.dragon ==1)
	{
		wood5.SetActive(false);
	}
}


	public void Blueplane () {	
		chnum = 1;
		SceneManager.LoadScene ("Menu5");
	}

	public void BuyPlane2 () {

		if(DBManager.planetwo ==1)
		{
			chnum = 2;
			SceneManager.LoadScene ("Menu5");
		}		   
	     else if (DBManager.coin>=60) {
			DBManager.planetwo=1;
			chnum = 2;
			DBManager.coin-=60;
			SceneManager.LoadScene ("Menu5");

			}
		else 
		{
			Debug.Log ("You Don't Have The Score");
		
		}
	}

	public void BuyPlane3 () {

		if(DBManager.planethree ==1)
		{
			chnum = 3;
			SceneManager.LoadScene ("Menu5");
		}			
	    else if (DBManager.coin>=120) {
			DBManager.planethree=1;
			chnum = 3;
			DBManager.coin-=120;
			SceneManager.LoadScene ("Menu5");

		}
		else 
		{
			Debug.Log ("You Don't Have The Score");

		}
	}

	public void BuyPlane4 () {

		if (DBManager.planefour ==1)
		{
			chnum = 4;
			SceneManager.LoadScene ("Menu5");
		}			
	    else if (DBManager.coin>=180) {
			DBManager.planefour=1;
		    chnum = 4;
			DBManager.coin-=180;
			SceneManager.LoadScene ("Menu5");
		}
		else 
		{
			Debug.Log ("You Don't Have The Score");

		}
	}

	public void BuyPlane5 () {

		if (DBManager.planefive ==1)
		{
			 chnum = 5;
			SceneManager.LoadScene ("Menu5");
		}          
		else if (DBManager.coin>=240) {
			DBManager.planefive=1;
		    chnum = 5;
			DBManager.coin-=240;
			SceneManager.LoadScene ("Menu5");
		}
		else 
		{
			Debug.Log ("You Don't Have The Score");

		}
	}
	public void BuyDragon () {

		if (DBManager.dragon ==1)
		{
			chnum = 6;
			SceneManager.LoadScene ("Menu5");
		}			
	    else if (DBManager.coin>=300) {
			DBManager.dragon =1;
			chnum = 6;
			DBManager.coin-=300;
			SceneManager.LoadScene ("Menu5");
		}
		else 
		{
			Debug.Log ("You Don't Have The Score");

		}
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
		
		}

		IEnumerator fr1(){
			yield return new WaitForSeconds (1f);
			frame1.SetActive(true);
			yield return new WaitForSeconds (3f);
			frame1.SetActive(false);
		}

		IEnumerator fr2(){
			yield return new WaitForSeconds (1f);
			frame2.SetActive(true);
			yield return new WaitForSeconds (3f);
			frame2.SetActive(false);
		}

		IEnumerator fr3(){
			yield return new WaitForSeconds (1f);
			frame3.SetActive(true);
			yield return new WaitForSeconds (3f);
			frame3.SetActive(false);
		}

		IEnumerator fr4(){
			yield return new WaitForSeconds (1f);
			frame4.SetActive(true);
			yield return new WaitForSeconds (3f);
			frame4.SetActive(false);
		}

		IEnumerator fr5(){
			yield return new WaitForSeconds (1f);
			frame5.SetActive(true);
			yield return new WaitForSeconds (3f);
			frame5.SetActive(false);
		}

		public void fram1(){
			StartCoroutine (fr1());
		}
		public void fram2(){
			StartCoroutine (fr2());
		}
		public void fram3(){
			StartCoroutine (fr3());
		}
		public void fram4(){
			StartCoroutine (fr4());
		}
		public void fram5(){
			StartCoroutine (fr5());

		}
			
}












	


	





		
		











	








