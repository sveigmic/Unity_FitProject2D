using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleHolder : MonoBehaviour {

    private GameMasterObject gm;

	void Start () {
        gm = GameObject.Find("GameMasterObject").GetComponent<GameMasterObject>();
    }

    public void Add()
    {
        gm.Castle.GetComponent<CastleBuildings>().GetTest();
    }
	
	// Update is called once per frame
	void Update () {
	}
}
