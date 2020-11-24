using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndUI : MonoBehaviour
{
	public float height=5;
	public GameObject gift1,gift2,gift3,gift4,gift5,mass,panel;

	
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(gifts());
      StartCoroutine(massage());
    }
    void Awake(){
    	gift1.SetActive(true);
    	gift2.SetActive(true);
    	gift3.SetActive(true);
    	gift4.SetActive(true);
    	gift5.SetActive(true);
    	mass.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    IEnumerator gifts(){
    	yield return new WaitForSeconds (5f);
    	Instantiate (gift1, new Vector3 (Random.Range (-height, height),5, 0), transform.rotation);
    	yield return new WaitForSeconds (3f);   
    	Instantiate (gift2, new Vector3 (Random.Range (-height, height),5, 0), transform.rotation);
    	yield return new WaitForSeconds (3f);  
    	Instantiate (gift3, new Vector3 (Random.Range (-height, height),5, 0), transform.rotation);
    	yield return new WaitForSeconds (3f);     
    	Instantiate (gift4, new Vector3 (Random.Range (-height, height),5, 0), transform.rotation);
    	yield return new WaitForSeconds (3f);
    	Instantiate (gift5, new Vector3 (Random.Range (-height, height),5, 0), transform.rotation);
    	StartCoroutine (gifts()); 
    }
    IEnumerator massage(){
    	mass.SetActive(true);
    	yield return new WaitForSeconds (5f);
    	mass.SetActive(false);
    	yield return new WaitForSeconds (2f);
    	panel.SetActive(true);

    }

}
