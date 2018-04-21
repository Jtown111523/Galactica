using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldmovement : MonoBehaviour {


    Transform player;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            player = col.GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void Update () {

        this.transform.position = player.position;
		
	}
}
