using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResources : MonoBehaviour {


    private int gold;
    private int wood;
    private int stones;
    private int dirt;
    private int gems;

    public int Gold
    {
        get { return gold; }
        set { gold = value; }
    }

    public int Wood
    {
        get { return wood; }
        set { wood = value; }
    }

    public int Stones
    {
        get { return stones; }
        set { stones = value; }
    }

    public int Dirt
    {
        get { return dirt; }
        set { dirt = value; }
    }

    public int Gems
    {
        get { return gems; }
        set { gems = value; }
    }
}
