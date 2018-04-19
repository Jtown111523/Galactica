using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScript : MonoBehaviour {

    [HideInInspector]
    public int anim;

    audioManager Audio;

    private void Awake()
    {
        Audio = FindObjectOfType<audioManager>();
    }

    public void playAgainButton()
    {
        //use if want to load level 1
        anim = 1;
        Audio.Play("Button Click");
    }

    public void homeButton()
    {
        //use to return to home screen
        anim = 2;
        Audio.Play("Button Click");
    }

    public void optionsButton()
    {
        //use to load options menu
        anim = 3;
        Audio.Play("Button Click");
    }

    public void quitButton()
    {
        anim = 4;
        Audio.Play("Button Click");
    }


	public void loadScreen()
    {
        if (anim == 1)
        {
            //load game screen
            SceneManager.LoadScene("Level01");
        }
        else if (anim == 2)
        {
            //load home screen
            SceneManager.LoadScene("StartScreen");
        }
        else if (anim == 3)
        {
            //load options screen
            SceneManager.LoadScene("OptionsScreen");
        }
        else if (anim == 4)
        {
            //quits game
            Application.Quit();
        }
    }
}
