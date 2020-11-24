using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    bool isMuted;
    // Start is called before the first frame update
    void Start()
    {
    isMuted=PlayerPrefs.GetFloat("Audio")==0?false:true;
    }

    // Update is called once per frame
    void Update()
    {
         AudioListener.pause=isMuted;
        if(Input.GetKey(KeyCode.Space)){
                isMuted=true;
                PlayerPrefs.SetFloat("Audio",1);
                                  

        }
    }
}
