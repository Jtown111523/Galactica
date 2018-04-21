using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldComp : MonoBehaviour {

    int shieldLives = 10;

    GameObject shieldExplosion;

    private void Start()
    {
        shieldExplosion = (GameObject)Resources.Load("ShieldExplosion");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Meteor" || col.gameObject.tag == "RedMeteor")
        {
            col.GetComponent<meteorCollision>().destroyMeteor();
            shieldLives--;
            if (shieldLives == 0)
            {
                Destroy(this.gameObject);
                Instantiate(shieldExplosion, this.gameObject.transform.position, Quaternion.identity);
            }
        }
    }
}
