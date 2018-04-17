using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{

    public float score = 0f;

    [HideInInspector]
    public float meteorWorth;

    public Text playerScoreText;

    // Update is called once per frame
    void Update()
    {

        playerScoreText.text = score.ToString();

        if (score <= 0)
        {
            SceneManager.LoadScene("EndScreen");
        }

    }

    public void addToScoreNorm()
    {
        score = score + meteorWorth;
    }

    public void addToScoreRed()
    {
        score = score + (meteorWorth * 1.5f);
    }
}
