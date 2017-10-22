using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadMainScene()
    {
        SceneManager.LoadScene("main");
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
      //  Application.Quit();
    }
}
