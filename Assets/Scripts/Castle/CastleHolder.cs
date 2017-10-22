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
        foreach (Creature x in gm.GetPlayer().GetComponent<PlayerArmy>().army)
        {
            Debug.Log(x.name + " > count: " + x.count);
        }
    }
	
	// Update is called once per frame
	void Update () {
	}
}
