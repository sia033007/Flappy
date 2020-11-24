using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xdirection= Input.GetAxis("Mouse X");
        float ydirection= Input.GetAxis ("Mouse Y");
        transform.Rotate(-ydirection,xdirection,0);
    }
    private void OnGUI() {
        GUI.color=Color.black;
        if(GUI.Button(new Rect(5,5,80,20),"Click Me")){
            print("The Button is Pressed");
        }
        
        
        
    }
}
