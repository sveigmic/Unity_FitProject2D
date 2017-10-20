using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CastleLeave : MonoBehaviour {

	public void LeaveCastle()
    {
       GameObject.Find("GameMasterObject").GetComponent<GameMasterObject>().LoadMap("main");
    }
}
