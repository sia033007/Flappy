using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
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
        checkIfRaycastHit();
    }
    void checkIfRaycastHit(){
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward,out hit)){
            print(hit.collider.gameObject.name + " has been destroyed");
            Destroy(hit.collider.gameObject);
        }
    }
}
