using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorCollision : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {

            Debug.Log(col.gameObject.tag);
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }

    }

}
