using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;


public class Mute : MonoBehaviour
{
	private bool isMuted;
    // Start is called before the first frame update
    void Start()
    {
       isMuted=ObscuredPrefs.GetInt("Muted")==1;
       AudioListener.pause=isMuted;

    }

  public void MutePressed(){
  	isMuted=!isMuted;
  	AudioListener.pause=isMuted;
  	ObscuredPrefs.SetInt("Muted",isMuted?1:0);

  }
}
