using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet : MonoBehaviour
{
    Rigidbody rb;

    
   
    
    // Start is called before the first frame update
    void Start()
    {
       rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.UpArrow)){
           transform.Translate(0,0,5);
       }
       if(Input.GetKey(KeyCode.DownArrow)){
           transform.Translate(0,0,-5);
       }
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(0,500,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-5,0,0);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(5,0,0);
        }

       
    }
    
    

}
