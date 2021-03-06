﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{

    public float score = 0;

    [HideInInspector]
    public float meteorWorth;

    public float scoreMultiplier = 1;

    public Text playerScoreText;



    // Update is called once per frame
    void Update()
    {

        playerScoreText.text = score.ToString("0");

        if (score <= 0)
        {
            SceneManager.LoadScene("EndScreen");
        }

    }

    public void addToScoreNorm()
    {
        score = score + (meteorWorth * scoreMultiplier);
    }

    public void addToScoreRed()
    {
        score = score + ((meteorWorth * 2) * scoreMultiplier);
    }
}
