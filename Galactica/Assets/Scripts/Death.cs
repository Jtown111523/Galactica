using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Meteor")
        {
            //end game
            Destroy(col.gameObject);
            Destroy(this.gameObject);

            SceneManager.LoadScene("EndScreen");
        }
    }

}
