using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmy: MonoBehaviour {

    public List<Creature> army;

    private void Start()
    {
        army = new List<Creature>(GameObject.Find("GameMasterObject").GetComponent<CreatureLoader>().human_Creatures.creatures);
    }

}
