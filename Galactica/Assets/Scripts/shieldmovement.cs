using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldmovement : MonoBehaviour {

    public Transform player;
	
	// Update is called once per frame
	void Update () {

        this.transform.position = player.position;
		
	}
}
