using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleBuildings : MonoBehaviour {

    int test;
	void Start () {
        test = 20;
	}
	
	// Update is called once per frame
	void Update () {
	}

    public int GetTest()
    {
        test += 10;
        return test;
    }
}
