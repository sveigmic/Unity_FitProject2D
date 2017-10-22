using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;


[XmlRoot("CreatureCollection")]
public class CreatureContainer {

    [XmlArray("Creatures")]
    [XmlArrayItem("Creature")]
    public List<Creature> creatures = new List<Creature>();

    public static CreatureContainer LoadHumanCreatures(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        if (_xml == null) Debug.Log("LOL");

        XmlSerializer serializer = new XmlSerializer(typeof(CreatureContainer));

        StringReader reader = new StringReader(_xml.text);

        CreatureContainer creatures = serializer.Deserialize(reader) as CreatureContainer;

        reader.Close();

        return creatures;
    }
 
}

