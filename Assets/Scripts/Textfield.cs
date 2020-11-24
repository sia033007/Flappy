using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using PersianSupportForSilverlight;

public class Textfield : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	string txtButton;
    string txtfield = "";
    string tempText = "";
    public GUISkin gs;
   
	void OnGUI()
	{
		    
            GUI.skin = gs;
            tempText = GUI.TextField(new Rect(20, 20, 400, 50), tempText);   
            GUI.Button (new Rect(20,20,400,50),txtButton);
           
            PersianMaker pm = new PersianMaker();
            txtfield = tempText;
            txtButton = pm.ToPersian(txtfield);
            
	}
}
