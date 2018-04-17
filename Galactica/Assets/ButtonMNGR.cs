using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMNGR : MonoBehaviour {

	public void playButtonPress()
    {
        SceneManager.LoadScene("Level01");
    }

    public void optionsButtonPress()
    {
        //send to options screen
    }

    public void quitButtonPress()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void homeButtonPress()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void playAgainButtonPress()
    {
        SceneManager.LoadScene("Level01");
    }
}
