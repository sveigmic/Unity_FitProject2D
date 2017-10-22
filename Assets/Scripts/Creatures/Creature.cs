using System.Collections;
using System.Xml;
using System.Xml.Serialization;


public class Creature {

    [XmlAttribute("name")]
    public string name;

    [XmlAttribute("HealthPerUnit")]
    public int healthPerUnit;

    [XmlAttribute("Attack")]
    public int attack;

    [XmlAttribute("Defense")]
    public int defense;

    [XmlAttribute("MoveSpeed")]
    public int moveSpeed;

    [XmlAttribute("Range")]
    public int range;

    [XmlAttribute("Cost")]
    public int cost;

    public int count = 0;

}
