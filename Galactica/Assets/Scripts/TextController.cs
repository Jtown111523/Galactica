using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text newHighScoreText;

    public Text highScoreText;

    Text highScore;

	// Use this for initialization
	void Start () {
        highScore = GetComponent<Text>();

        highScore.text = PlayerPrefs.GetInt("highScore").ToString("0");

        if (PlayerPrefs.GetInt("newHighScore") == 1)
        {
            //display new high score Text
            newHighScoreText.gameObject.SetActive(true);

            //change back to 2
            PlayerPrefs.SetInt("newHighScore", 2);
        }
        else
        {
            //display high score Text
            highScoreText.gameObject.SetActive(true);
        }

		
	}
	
}
