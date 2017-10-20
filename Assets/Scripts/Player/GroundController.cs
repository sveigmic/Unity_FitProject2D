using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GroundController : MonoBehaviour {

    BoxCollider2D coll;
    PlayerController player;
    public LayerMask mask;
    public bool onPath;

    // Use this for initialization
    void Start () {
        coll = GetComponent<BoxCollider2D>();
        player = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        setSpeed();
	}

    public void setSpeed() 
    {
        Vector3 rayStart;

        rayStart = rayStart = coll.bounds.center;

        Debug.DrawRay(rayStart, Vector3.down, Color.red);
        if (Physics2D.Raycast(rayStart, Vector3.down, (coll.size.y / 2) + 0.1f, mask)) {
            player.moveSpeed = 7;
         } else player.moveSpeed = 4;
       
    }
}
