﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Planesea2 : MonoBehaviour
{
    

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
     Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0 || screenPosition.x<-8) {
            SceneManager.LoadScene("Sea2");

        }   
    }
}