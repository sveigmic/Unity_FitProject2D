using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerResourcesController : MonoBehaviour {

	public void AddWood(int count)
    {
        PlayerResources res = GetComponent<PlayerResources>();
        res.Wood = res.Wood + count;
        GameObject.Find("Wood").GetComponent<Text>().text = res.Wood.ToString();
        Debug.Log("Mam drevo: " + res.Wood);
    }
}
