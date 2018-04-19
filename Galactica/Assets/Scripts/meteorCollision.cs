using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorCollision : MonoBehaviour {

    public ScoreKeeper scoreKeeper;
    public MeteorSpawn meteorSpawn;
    GameObject explosionPrefab;
    audioManager Audio;

    public void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        meteorSpawn = FindObjectOfType<MeteorSpawn>();
        scoreKeeper.meteorWorth = Random.Range(0, 10) * 10;
        explosionPrefab = (GameObject)Resources.Load("Explosion");
        Audio = FindObjectOfType<audioManager>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);

            Audio.Play("Meteor Explosion");

            Instantiate(explosionPrefab, this.gameObject.transform.position, Quaternion.identity);

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
