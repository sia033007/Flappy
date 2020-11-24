using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerator : MonoBehaviour
{
	Rigidbody2D rb;
	float diry;
	float movespeed=30f;
    float y=5;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
      diry=Input.acceleration.y*movespeed;
      transform.position=new Vector2 (0,Random.Range (-y,y));
    }
    void FixedUpdate (){
    	rb.velocity=new Vector2(0f,diry);
    }
}
