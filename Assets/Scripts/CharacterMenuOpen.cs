using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMenuOpen : MonoBehaviour {

    public bool isOpen;
    public GameObject characterMenu;


	// Use this for initialization
	void Start () {
        isOpen = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("CharacterMenu"))
        {
            isOpen = !isOpen;
        }
        if (isOpen)
        {
            characterMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            characterMenu.SetActive(false);
            Time.timeScale = 1;
        }
	}
}
