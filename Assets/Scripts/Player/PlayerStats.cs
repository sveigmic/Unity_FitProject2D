using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    private int attack;
    private int defense;
    private float moveSpeed;
    private int spellPower;
    private int experience;
    private int level;

    public int Attack
    {
        get { return attack; }
        set { attack = value; }
    }

    public int Defense
    {
        get { return defense; }
        set { defense = value; }
    }

    public int SpellPower
    {
        get { return spellPower; }
        set { spellPower = value; }
    }

    public float MoveSpeed
    {
        get { return moveSpeed; }
        set { moveSpeed = value; }
    }

    public int Experience
    {
        get { return experience; }
        set { experience = value; }
    }

    public int Level
    {
        get { return level; }
        set { level = value; }
    }
}
