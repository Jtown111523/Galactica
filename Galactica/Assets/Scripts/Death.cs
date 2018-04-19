using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

    ScoreKeeper scoreKeeper;

    GameObject meteorPrefab;

    int highScore;

    int totalScore;

    private void Start()
    {
        meteorPrefab = (GameObject)Resources.Load("Explosion");
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Meteor" || col.gameObject.tag =="RedMeteor")
        {
            //end game
            Destroy(col.gameObject);
            Destroy(this.gameObject);

            Instantiate(meteorPrefab, this.gameObject.transform.position, Quaternion.identity);

            //Save Score
            saveScore();

            SceneManager.LoadScene("EndScreen");
        }
    }

    void saveScore()
    {
        highScore = PlayerPrefs.GetInt("highScore");
        if (scoreKeeper.score > highScore)
        {
            //sets new high score
            PlayerPrefs.SetInt("highScore", scoreKeeper.score);
            highScore = PlayerPrefs.GetInt("highScore");
            //Debug.Log("HighScore: " + highScore);
        }


        //adds to total score visible from startScreen
        totalScore = PlayerPrefs.GetInt("totalScore") + scoreKeeper.score;
        PlayerPrefs.SetInt("totalScore", totalScore);

        //Debug.Log("Total Score: " + totalScore);

    }

}
