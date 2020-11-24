using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusAnim : MonoBehaviour
{
	public Animator anim;
	float movespeed=10f;
	float dirx;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate (){
    	Animator anim;
    	anim=GetComponent<Animator>();
    	dirx=Input.acceleration.x*movespeed;
		anim.transform.position=new Vector2 (Mathf.Clamp(transform.position.x,-7f,7f),transform.position.y);
    }
}
