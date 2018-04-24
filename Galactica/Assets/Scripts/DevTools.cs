using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevTools : MonoBehaviour {

    int totalScore;



    private void Start()
    {
        totalScore = PlayerPrefs.GetInt("totalScore");
    }


    // Update is called once per frame
    void Update () {

        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.R) && Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("erase");
            eraseAllPlayerPrefs();
        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Equals))
        {
            Debug.Log("add funds");
            giveTotalScore();
        }
		
	}


    void eraseAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    void giveTotalScore()
    {
        totalScore = PlayerPrefs.GetInt("totalScore");
        totalScore = totalScore + 500000;
        PlayerPrefs.SetInt("totalScore", totalScore);
    }
}
