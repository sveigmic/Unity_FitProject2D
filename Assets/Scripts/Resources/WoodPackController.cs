using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodPackController : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<PlayerResourcesController>().AddWood(10);
        Destroy(this.gameObject);
    }
}
