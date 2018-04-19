using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

    GameObject meteorPrefab;

    private void Start()
    {
        meteorPrefab = (GameObject)Resources.Load("Explosion");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Meteor" || col.gameObject.tag =="RedMeteor")
        {
            //end game
            Destroy(col.gameObject);
            Destroy(this.gameObject);

            Instantiate(meteorPrefab, this.gameObject.transform.position, Quaternion.identity);

            SceneManager.LoadScene("EndScreen");
        }
    }

}
