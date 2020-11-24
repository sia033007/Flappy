using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy5 : MonoBehaviour
{
    public Slider slider;
	public Slider slider2;
	public Slider slider3;
	public Slider slider5;
	public GameObject bubble;
	public float timer;
	public int delay = 1;
	public Animator anim;
	public GameObject bullet;
	public GameObject bullets;
	public GameObject explosion;
	public GameObject aud;
	public Transform tr1;
	public Transform tr2;
	
	
    // Start is called before the first frame update
    void Start()
    {
        slider=GameObject.Find("Canvas").GetComponent<UIEnemy1>().slider;
        slider2=GameObject.Find("Canvas").GetComponent<UIEnemy1>().slider1;
        slider3=GameObject.Find("Canvas").GetComponent<UIEnemy1>().slider3;
        slider5=GameObject.Find("Canvas").GetComponent<UIEnemy1>().slider5;
        anim=GetComponent<Animator>();
        InvokeRepeating ("shoot",2f,1f);
        
       

        
        

    }

    // Update is called once per frame
    void Update()
    {
    	timer += Time.deltaTime;

    	if (timer >= delay && bubble.activeInHierarchy==false) {
			timer = 0f;
			slider.value-=4;
		}
       
        if(slider3.value==80){
        	Destroy (gameObject);
        	explosion.SetActive(true);
        } 
        if(slider3.value==80){
        	aud.SetActive(true);
        } 
        else{
        	aud.SetActive(false);
        }       
    }
    void FixedUpdate (){
    	StartCoroutine(go1());	
       
        StartCoroutine(go());	
        
        StartCoroutine(go3());
        
        StartCoroutine(go4());

    }

    void shoot(){
    	Instantiate(bullet,tr1.position,transform.rotation);
    }
    void shoots(){
    	Instantiate(bullets,tr2.position,transform.rotation);
    }

    IEnumerator go (){
    	if(slider.value==0 && slider5.value!=80){
        	bubble.SetActive(true);
        	bullets.SetActive(false);
    	    yield return new WaitForSeconds(3f);
            anim.SetTrigger("trig1");
            yield return new WaitForSeconds (6f);
            anim.SetTrigger("trig1");
        }
    }

    IEnumerator go1 (){
    	if(slider.value==40 && slider5.value!=80){
        	bubble.SetActive(false);
        	bullets.SetActive(true);
        	InvokeRepeating("shoots",2f,5f);
    	    yield return new WaitForSeconds (3f);
    	    anim.SetTrigger("trig2");
    	}
    }
    IEnumerator go3 (){
    	 if(slider.value==0 && slider5.value==80){
        	bubble.SetActive(true);
        	bullets.SetActive(false);
    	    yield return new WaitForSeconds (2f);
    	    anim.SetTrigger("trig3");
    	    yield return new WaitForSeconds (3f);
    	    anim.SetTrigger("trig5");
    	    yield return new WaitForSeconds (3f);
    	    anim.SetTrigger("trig3");
    	    yield return new WaitForSeconds (2f);
    	    anim.SetTrigger("trig5");
    	}
    }
    IEnumerator go4 (){
    	 if(slider.value==40 && slider5.value==80){
        	bubble.SetActive(false);
        	bullets.SetActive(true);
        	InvokeRepeating("shoots",2f,5f);
    	    yield return new WaitForSeconds (2f);
    	    anim.SetTrigger("trig4");
    	    yield return new WaitForSeconds (3f);
    	    anim.SetTrigger("trig4");
    	}
    }
    
    void OnCollisionEnter2D (Collision2D col){
    	if(col.gameObject.tag== "Player"){
    		slider2.value+=2;

    	}
    }
    
}
