using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMenu5 : MonoBehaviour
{
    int SceneIndex;
	public Button l1,l2,l3,l4,l5,l6,l7,l8,l9,l10,l11,l12,l13,l14,l15;
	public GameObject lo1,lo2,lo3,lo4,lo5,lo6,lo7,lo8,lo9,lo10,lo11,lo12,lo13,lo14;
	public GameObject load;
    // Start is called before the first frame update
    void Start()
    {
        SceneIndex = SceneManager.GetActiveScene ().buildIndex;
        if(DBManager.level==2)
		{
			lo1.SetActive(false);
			l1.interactable = false;
		}
		if(DBManager.level==3)
		{
			lo1.SetActive(false);
			l1.interactable = false;
			lo2.SetActive(false);
			l2.interactable = false;
		}
		if(DBManager.level==4)
		{
			lo1.SetActive(false);
			l1.interactable = false;
			lo2.SetActive(false);
			l2.interactable = false;
			lo3.SetActive(false);
			l3.interactable = false;
		}
		if(DBManager.level==5)
		{
			lo1.SetActive(false);
			l1.interactable = false;
			lo2.SetActive(false);
			l2.interactable = false;
			lo3.SetActive(false);
			l3.interactable = false;
			lo4.SetActive(false);
			l4.interactable = false;
		}
		if(DBManager.level==6)
		{
			lo1.SetActive(false);
			l1.interactable = false;
			lo2.SetActive(false);
			l2.interactable = false;
			lo3.SetActive(false);
			l3.interactable = false;
			lo4.SetActive(false);
			l4.interactable = false;
			lo5.SetActive(false);
			l5.interactable = false;
		}
		if(DBManager.level==7)
		{
			lo1.SetActive(false);
			l1.interactable = false;
			lo2.SetActive(false);
			l2.interactable = false;
			lo3.SetActive(false);
			l3.interactable = false;
			lo4.SetActive(false);
			l4.interactable = false;
			lo5.SetActive(false);
			l5.interactable = false;
			lo6.SetActive(false);
			l6.interactable = false;
		}
		if(DBManager.level==8)
		{
			lo1.SetActive(false);
			l1.interactable = false;
			lo2.SetActive(false);
			l2.interactable = false;
			lo3.SetActive(false);
			l3.interactable = false;
			lo4.SetActive(false);
			l4.interactable = false;
			lo5.SetActive(false);
			l5.interactable = false;
			lo6.SetActive(false);
			l6.interactable = false;
			lo7.SetActive(false);
			l7.interactable = false;
		}
		if(DBManager.level==9)
		{
			lo1.SetActive(false);
			l1.interactable = false;
			lo2.SetActive(false);
			l2.interactable = false;
			lo3.SetActive(false);
			l3.interactable = false;
			lo4.SetActive(false);
			l4.interactable = false;
			lo5.SetActive(false);
			l5.interactable = false;
			lo6.SetActive(false);
			l6.interactable = false;
			lo7.SetActive(false);
			l7.interactable = false;
			lo8.SetActive(false);
			l8.interactable = false;
		}
		if(DBManager.level==10)
		{
			lo1.SetActive(false);
			l1.interactable = false;
			lo2.SetActive(false);
			l2.interactable = false;
			lo3.SetActive(false);
			l3.interactable = false;
			lo4.SetActive(false);
			l4.interactable = false;
			lo5.SetActive(false);
			l5.interactable = false;
			lo6.SetActive(false);
			l6.interactable = false;
			lo7.SetActive(false);
			l7.interactable = false;
			lo8.SetActive(false);
			l8.interactable = false;
			lo9.SetActive(false);
			l9.interactable = false;
		}
		if(DBManager.level==11)
		{
			lo1.SetActive(false);
			l1.interactable = false;
			lo2.SetActive(false);
			l2.interactable = false;
			lo3.SetActive(false);
			l3.interactable = false;
			lo4.SetActive(false);
			l4.interactable = false;
			lo5.SetActive(false);
			l5.interactable = false;
			lo6.SetActive(false);
			l6.interactable = false;
			lo7.SetActive(false);
			l7.interactable = false;
			lo8.SetActive(false);
			l8.interactable = false;
			lo9.SetActive(false);
			l9.interactable = false;
			lo10.SetActive(false);
			l10.interactable = false;
		}
		if(DBManager.level==12)
		{
			lo1.SetActive(false);
			l1.interactable = false;
			lo2.SetActive(false);
			l2.interactable = false;
			lo3.SetActive(false);
			l3.interactable = false;
			lo4.SetActive(false);
			l4.interactable = false;
			lo5.SetActive(false);
			l5.interactable = false;
			lo6.SetActive(false);
			l6.interactable = false;
			lo7.SetActive(false);
			l7.interactable = false;
			lo8.SetActive(false);
			l8.interactable = false;
			lo9.SetActive(false);
			l9.interactable = false;
			lo10.SetActive(false);
			l10.interactable = false;
			lo11.SetActive(false);
			l11.interactable = false;
		}
		if(DBManager.level==13)
		{
			lo1.SetActive(false);
			l1.interactable = false;
			lo2.SetActive(false);
			l2.interactable = false;
			lo3.SetActive(false);
			l3.interactable = false;
			lo4.SetActive(false);
			l4.interactable = false;
			lo5.SetActive(false);
			l5.interactable = false;
			lo6.SetActive(false);
			l6.interactable = false;
			lo7.SetActive(false);
			l7.interactable = false;
			lo8.SetActive(false);
			l8.interactable = false;
			lo9.SetActive(false);
			l9.interactable = false;
			lo10.SetActive(false);
			l10.interactable = false;
			lo11.SetActive(false);
			l11.interactable = false;
			lo12.SetActive(false);
			l12.interactable = false;
		}
		if(DBManager.level==14)
		{
			l1.interactable = false;
			lo2.SetActive(false);
			l2.interactable = false;
			lo3.SetActive(false);
			l3.interactable = false;
			lo4.SetActive(false);
			l4.interactable = false;
			lo5.SetActive(false);
			l5.interactable = false;
			lo6.SetActive(false);
			l6.interactable = false;
			lo7.SetActive(false);
			l7.interactable = false;
			lo8.SetActive(false);
			l8.interactable = false;
			lo9.SetActive(false);
			l9.interactable = false;
			lo10.SetActive(false);
			l10.interactable = false;
			lo11.SetActive(false);
			l11.interactable = false;
			lo12.SetActive(false);
			l12.interactable = false;
			lo13.SetActive(false);
			l13.interactable = false;
		}
		if(DBManager.level==15)
		{
			l1.interactable = false;
			lo2.SetActive(false);
			l2.interactable = false;
			lo3.SetActive(false);
			l3.interactable = false;
			lo4.SetActive(false);
			l4.interactable = false;
			lo5.SetActive(false);
			l5.interactable = false;
			lo6.SetActive(false);
			l6.interactable = false;
			lo7.SetActive(false);
			l7.interactable = false;
			lo8.SetActive(false);
			l8.interactable = false;
			lo9.SetActive(false);
			l9.interactable = false;
			lo10.SetActive(false);
			l10.interactable = false;
			lo11.SetActive(false);
			l11.interactable = false;
			lo12.SetActive(false);
			l12.interactable = false;
			lo13.SetActive(false);
			l13.interactable = false;
			lo14.SetActive(false);
			l14.interactable = false;
		}

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Escape)){
            SceneManager.LoadScene (SceneIndex -3);
        }

        l1.onClick.AddListener(() =>{
        	load.SetActive(true);
        	SceneManager.LoadScene("Knight1");

        	});
        l2.onClick.AddListener(() =>{
			if(lo1.activeInHierarchy == false)
			{
			load.SetActive(true);
        	SceneManager.LoadScene("Knight2");

			}
        	});
        l3.onClick.AddListener(() =>{
        	if(lo2.activeInHierarchy == false){
        		load.SetActive(true);
        		SceneManager.LoadScene("Enemy1");
        	}

        	});
        l4.onClick.AddListener(() =>{
        	if(lo3.activeInHierarchy == false){
        		load.SetActive(true);
        		SceneManager.LoadScene("Western1");
        	}

        	});
        l5.onClick.AddListener(() =>{
        	if(lo4.activeInHierarchy == false){
        		load.SetActive(true);
        		SceneManager.LoadScene("Western2");
        	}

        	});
        l6.onClick.AddListener(() =>{
        	if(lo5.activeInHierarchy == false){
        		load.SetActive(true);
        		SceneManager.LoadScene("Enemy2");
        	}

        	});
        l7.onClick.AddListener(() =>{
        	if(lo6.activeInHierarchy == false){
        		load.SetActive(true);
        		SceneManager.LoadScene("Chris1");
        	}

        	});
        l8.onClick.AddListener(() =>{
        	if(lo7.activeInHierarchy == false){
        		load.SetActive(true);
        		SceneManager.LoadScene("Chris2");
        	}

        	});
        l9.onClick.AddListener(() =>{
        	if(lo8.activeInHierarchy == false){
        		load.SetActive(true);
        		SceneManager.LoadScene("Enemy3");
        	}

        	});
        l10.onClick.AddListener(() =>{
        	if(lo9.activeInHierarchy == false){
        		load.SetActive(true);
        		SceneManager.LoadScene("Sea1");
        	}

        	});
        l11.onClick.AddListener(() =>{
        	if(lo10.activeInHierarchy == false){
        		load.SetActive(true);
        		SceneManager.LoadScene("Sea2");
        	}

        	});
        l12.onClick.AddListener(() =>{
        	if(lo11.activeInHierarchy == false){
        		load.SetActive(true);
        		SceneManager.LoadScene("Enemy4");
        	}

        	});
        l13.onClick.AddListener(() =>{
        	if(lo12.activeInHierarchy == false){
        		load.SetActive(true);
        		SceneManager.LoadScene("Factory1");
        	}

        	});
        l14.onClick.AddListener(() =>{
        	if(lo13.activeInHierarchy == false){
        		load.SetActive(true);
        		SceneManager.LoadScene("Factory2");
        	}

        	});
        l15.onClick.AddListener(() =>{
        	if(lo14.activeInHierarchy == false){
        		load.SetActive(true);
        		SceneManager.LoadScene("Enemy5");
        	}

       	});
    }
}
