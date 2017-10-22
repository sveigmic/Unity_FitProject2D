using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureLoader : MonoBehaviour {

    private string humanCreaturesPath = "human_creatures";
    private string undeadCreaturesPath = "undead_creatures";

    public CreatureContainer human_Creatures;
    public CreatureContainer undead_Creatures;


    // Use this for initialization
    void Start () {
        human_Creatures = CreatureContainer.LoadHumanCreatures(humanCreaturesPath);
        undead_Creatures = CreatureContainer.LoadHumanCreatures(undeadCreaturesPath);
        foreach (Creature c in human_Creatures.creatures)
        {
            Debug.Log(c.name + " > " + c.healthPerUnit);

        }
        Debug.Log("------------------------------------");
        foreach (Creature c in undead_Creatures.creatures)
        {
            Debug.Log(c.name + " > " + c.healthPerUnit);

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
