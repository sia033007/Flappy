using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiePlane4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0 || transform.position.x<-10.25) {
            SceneManager.LoadScene("Enemy1");

        }   
    }
}
