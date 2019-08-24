using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hairetu : MonoBehaviour {

	// Use this for initialization
	void Start () {    
        int[] array = new int[5];

        array[0] = 30;
        array[1] = 50;
        array[2] = 70;
        array[3] = 90;
        array[4] = 110;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for(int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }
		
    
	// Update is called once per frame
	void Update () {
		
	}
}
