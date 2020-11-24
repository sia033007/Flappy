using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    ParticleSystem par;
    // Start is called before the first frame update
    void Start()
    {
      par=GetComponent<ParticleSystem>();  
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            par.Play();
            
        }
    }
}
