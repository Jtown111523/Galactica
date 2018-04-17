using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBullet : MonoBehaviour {

    public ScoreKeeper scoreKeeper;

    public void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject);
        }
        

        if(col.gameObject.tag == "Meteor" || col.gameObject.tag == "RedMeteor")
        {
            scoreKeeper.score -= 50f;
            Destroy(col.gameObject);
        }
    }

}
