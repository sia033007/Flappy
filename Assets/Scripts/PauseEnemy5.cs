using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseEnemy5 : MonoBehaviour
{
   public GameObject pause;
   public AudioSource [] aud;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape)){
			pause.SetActive(true);
		    Time.timeScale = 0;
		    aud[0].Pause();
		    aud[1].Pause();
		} 
    }

    public void resume(){
    	pause.SetActive(false);
		aud[0].UnPause();
		aud[1].UnPause();
		Time.timeScale=1;
		
    }
    public void reload (){
    	pause.SetActive(false);
		SceneManager.LoadScene ("Enemy5");
		aud[0].UnPause();
		aud[1].UnPause();
		Time.timeScale=1;
    }

    public void home(){

    }
}
