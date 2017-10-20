using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Castne1Entry : MonoBehaviour {

    private void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = gameObject.transform.position - new Vector3(0, 1, 0);
        GameMasterObject gm = GameObject.Find("GameMasterObject").GetComponent<GameMasterObject>();
        gm.Castle = gameObject;
        gm.LoadCastle("Castle1");
         
    }
}
