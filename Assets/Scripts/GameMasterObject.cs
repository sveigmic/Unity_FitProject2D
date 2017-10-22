using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMasterObject : MonoBehaviour {

    private static bool isCreated;
    private bool timeStop = false;
    private GameObject player;
    private GameObject castle;
  //  private TimeStopper timeStopper;

	// Use this for initialization
	void Start () {
        if(!isCreated)
        {
            isCreated = true;
            DontDestroyOnLoad(this.gameObject);
        } else
        {
            DestroyObject(this.gameObject);
        }
        player = GameObject.Find("Player");
	}

	void Update () {
        
	}

    public void LoadCastle(string castle)
    {
        Application.LoadLevelAdditive(castle);
        player.SetActive(false);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(castle));
    }

    public void LoadMap(string map)
    {
        Application.UnloadLevel("Castle1");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(map));
        player.SetActive(true);
    }

    public void LoadBattleField(string battleField)
    {
        Application.LoadLevelAdditive(battleField);
        foreach (GameObject x in SceneManager.GetSceneByName("main").GetRootGameObjects()) x.SetActive(false);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(battleField));
    }

    public void LoadMapFromBattleField(string map)
    {
        Application.UnloadLevel("BattleField");
        foreach (GameObject x in SceneManager.GetSceneByName(map).GetRootGameObjects()) x.SetActive(true);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(map));
    }

    public GameObject GetPlayer()
    {
        return player;
    }

    public GameObject Castle
    {
        get { return castle;  }
        set { castle = value; }
    }
} 
