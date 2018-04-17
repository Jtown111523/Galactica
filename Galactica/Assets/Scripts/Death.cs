using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Meteor")
        {
            //end game
            Debug.Log("end Game");

            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }

}
