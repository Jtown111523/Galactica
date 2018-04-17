using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorCollision : MonoBehaviour {

    public ScoreKeeper scoreKeeper;
    public MeteorSpawn meteorSpawn;

    public void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        meteorSpawn = FindObjectOfType<MeteorSpawn>();
        scoreKeeper.meteorWorth = Random.Range(0, 10) * 10;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);

            //decrease time between spawns

            meteorSpawn.timeToNextSpawn -= .0025f;

            //add to score
            if(this.gameObject.tag == "RedMeteor")
            {
                scoreKeeper.addToScoreRed();
            }
            else
            {
                //add to score
                scoreKeeper.addToScoreNorm();
            }

        }

    }

}
