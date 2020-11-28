using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;
using UnityEngine.Networking;
public class MainMenu : MonoBehaviour {

	int SceneIndex;
	public GameObject wood;
	public GameObject music;
	public GameObject gift,nogift,bonuslevel;

	void Awake (){
		if(ObscuredPrefs.GetString("firstplay")!="no"){
			gift.SetActive(true);
        	nogift.SetActive(false);
		}
		ObscuredPrefs.SetString("Shop","Off");
		ObscuredPrefs.SetString("save","off");

	}	
	
	void Start () {
		
		music = GameObject.FindGameObjectWithTag ("music");
		if(ObscuredPrefs.GetString("Bonus")=="Off"){
			gift.SetActive(false);
			nogift.SetActive(true);      	
        }
        if(ObscuredPrefs.GetString("Bonus")=="On" && Date.click==true){
        	gift.SetActive(true);
        	nogift.SetActive(false);
        }
	}



	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Escape)) {
			wood.SetActive (true);
			music.GetComponent<AudioSource> ().Pause ();
		
		
		}
	}

	public void Startgame () {

		SceneManager.LoadScene ("Menu3");



	}

	public void Exitgame () {
		wood.SetActive (true);
		music.GetComponent<AudioSource> ().Pause ();

		}

	public void Shop () {
		SceneManager.LoadScene ("shop");
	}

	public void yes () {
		Application.Quit ();
	}

	public void no () {
		wood.SetActive (false);
		music.GetComponent<AudioSource> ().UnPause ();
		
	}

	public void Rahnama () {
		SceneManager.LoadScene ("rahnama");
	}

	public void Tamas () {
		SceneManager.LoadScene ("tamas");
	}
	public void Bonus () {
		SceneManager.LoadScene(Random.Range(23,28));
	}
	public void GoToScoreBoard()
	{
		
		SceneManager.LoadScene("Leader");
	}
	public void RateUs()
	{
		Application.OpenURL("bazaar://details?id=com.Gameone.Tayyare");
		ObscuredPrefs.SetString ("Bonus","Off");
	}
	IEnumerator bon (){
		yield return new WaitForSeconds (1f);
		bonuslevel.SetActive(true);
		yield return new WaitForSeconds (5f);
		bonuslevel.SetActive(false);
	}
	public void bonuses (){
		StartCoroutine (bon());
	}
	IEnumerator dataSave()
    {
        WWWForm form = new WWWForm();
        form.AddField("name",DBManager.username);
        form.AddField("score",DBManager.coin);
        form.AddField("level",DBManager.level);
        form.AddField("planetwo",DBManager.planetwo);
        form.AddField("planethree",DBManager.planethree);
        form.AddField("planefour",DBManager.planefour);
        form.AddField("planefive",DBManager.planefive);
        form.AddField("dragon",DBManager.dragon);

        using(UnityWebRequest request = UnityWebRequest.Post("http://aminunity.orgfree.com/samplegame.php",form))
        {
            yield return request.SendWebRequest();
            if(request.downloadHandler.text == "0")
            {
                Debug.Log("Game saved");
            }
            else
            {
                Debug.Log("Save failed" + request.downloadHandler.text);
            }
        }
    }
	public void SaveData()
	{
		StartCoroutine(dataSave());
	}
}


