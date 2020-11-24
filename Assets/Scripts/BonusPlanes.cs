using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPlanes : MonoBehaviour
{
	public GameObject[] planes;
	public int index;
	public GameObject Currentplane;

    // Start is called before the first frame update
    void Start()
    {
        index = Random.Range (0, planes.Length);
		Currentplane = planes [index];
		Currentplane.SetActive (true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
