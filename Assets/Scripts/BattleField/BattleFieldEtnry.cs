using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFieldEtnry : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = gameObject.transform.position + new Vector3(0, 1, 0);
        GameMasterObject gm = GameObject.Find("GameMasterObject").GetComponent<GameMasterObject>();
        gm.LoadBattleField("BattleField");
    }
}
