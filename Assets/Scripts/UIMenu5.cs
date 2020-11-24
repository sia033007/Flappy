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
        PlayerPrefs.SetString("Level1","On");
        if(PlayerPrefs.GetString("Level2")=="On"){
        	lo1.SetActive(false);
        }
        if(PlayerPrefs.GetString("Level3")=="On"){
        	lo2.SetActive(false);
        }
        if(PlayerPrefs.GetString("Level4")=="On"){
        	lo3.SetActive(false);
        }
        if(PlayerPrefs.GetString("Level5")=="On"){
        	lo4.SetActive(false);
        }
        if(PlayerPrefs.GetString("Level6")=="On"){
        	lo5.SetActive(false);
        }
        if(PlayerPrefs.GetString("Level7")=="On"){
        	lo6.SetActive(false);
        }
        if(PlayerPrefs.GetString("Level8")=="On"){
        	lo7.SetActive(false);
        }
        if(PlayerPrefs.GetString("Level9")=="On"){
        	lo8.SetActive(false);
        }
        if(PlayerPrefs.GetString("Level10")=="On"){
        	lo9.SetActive(false);
        }
        if(PlayerPrefs.GetString("Level11")=="On"){
        	lo10.SetActive(false);
        }
        if(PlayerPrefs.GetString("Level12")=="On"){
        	lo11.SetActive(false);
        }
        if(PlayerPrefs.GetString("Level13")=="On"){
        	lo12.SetActive(false);
        }
        if(PlayerPrefs.GetString("Level14")=="On"){
        	lo13.SetActive(false);
        }
        if(PlayerPrefs.GetString("Level15")=="On"){
        	lo14.SetActive(false);
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
        	if(PlayerPrefs.GetString("Level2")=="On"){
        		load.SetActive(true);
        		SceneManager.LoadScene("Knight2");
        	}

        	});
        l3.onClick.AddListener(() =>{
        	if(PlayerPrefs.GetString("Level3")=="On"){
        		load.SetActive(true);
        		SceneManager.LoadScene("Enemy1");
        	}

        	});
        l4.onClick.AddListener(() =>{
        	if(PlayerPrefs.GetString("Level4")=="On"){
        		load.SetActive(true);
        		SceneManager.LoadScene("Western1");
        	}

        	});
        l5.onClick.AddListener(() =>{
        	if(PlayerPrefs.GetString("Level5")=="On"){
        		load.SetActive(true);
        		SceneManager.LoadScene("Western2");
        	}

        	});
        l6.onClick.AddListener(() =>{
        	if(PlayerPrefs.GetString("Level6")=="On"){
        		load.SetActive(true);
        		SceneManager.LoadScene("Enemy2");
        	}

        	});
        l7.onClick.AddListener(() =>{
        	if(PlayerPrefs.GetString("Level7")=="On"){
        		load.SetActive(true);
        		SceneManager.LoadScene("Chris1");
        	}

        	});
        l8.onClick.AddListener(() =>{
        	if(PlayerPrefs.GetString("Level8")=="On"){
        		load.SetActive(true);
        		SceneManager.LoadScene("Chris2");
        	}

        	});
        l9.onClick.AddListener(() =>{
        	if(PlayerPrefs.GetString("Level9")=="On"){
        		load.SetActive(true);
        		SceneManager.LoadScene("Enemy3");
        	}

        	});
        l10.onClick.AddListener(() =>{
        	if(PlayerPrefs.GetString("Level10")=="On"){
        		load.SetActive(true);
        		SceneManager.LoadScene("Sea1");
        	}

        	});
        l11.onClick.AddListener(() =>{
        	if(PlayerPrefs.GetString("Level11")=="On"){
        		load.SetActive(true);
        		SceneManager.LoadScene("Sea2");
        	}

        	});
        l12.onClick.AddListener(() =>{
        	if(PlayerPrefs.GetString("Level12")=="On"){
        		load.SetActive(true);
        		SceneManager.LoadScene("Enemy4");
        	}

        	});
        l13.onClick.AddListener(() =>{
        	if(PlayerPrefs.GetString("Level13")=="On"){
        		load.SetActive(true);
        		SceneManager.LoadScene("Factory1");
        	}

        	});
        l14.onClick.AddListener(() =>{
        	if(PlayerPrefs.GetString("Level14")=="On"){
        		load.SetActive(true);
        		SceneManager.LoadScene("Factory2");
        	}

        	});
        l15.onClick.AddListener(() =>{
        	if(PlayerPrefs.GetString("Level15")=="On"){
        		load.SetActive(true);
        		SceneManager.LoadScene("Enemy5");
        	}

        	});
    }
}
