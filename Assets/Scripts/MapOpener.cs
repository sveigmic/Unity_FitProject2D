using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapOpener : MonoBehaviour {

    public bool isOpen;
    public GameObject map;


    // Use this for initialization
    void Start()
    {
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Map"))
        {
            isOpen = !isOpen;
        }
        if (isOpen)
        {
            map.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            map.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
