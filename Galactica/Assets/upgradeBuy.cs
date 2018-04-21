using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgradeBuy : MonoBehaviour {

   public int shieldCost;

   int totalPoints;

    int shieldCount;

    public Text numberText;

    public Button shieldButton;

    private void Awake()
    {
        totalPoints = PlayerPrefs.GetInt("totalScore");
        shieldCount = PlayerPrefs.GetInt("ShieldCount");
        numberText.text = "Currently Owned: " + PlayerPrefs.GetInt("ShieldCount").ToString("0");
        checkIfInteractable();
    }

    public void buyShield()
    {
        if (totalPoints - shieldCost >= 0)
        {
            //subtract cost from the total points
            totalPoints = PlayerPrefs.GetInt("totalScore");
            totalPoints = totalPoints - shieldCost;
            PlayerPrefs.SetInt("totalScore", totalPoints);

            //add to shield count
            shieldCount = PlayerPrefs.GetInt("ShieldCount");
            shieldCount++;
            PlayerPrefs.SetInt("ShieldCount", shieldCount);

            //display new # owned on bottom

            numberText.text = "Currently Owned: " + PlayerPrefs.GetInt("ShieldCount").ToString("0");

            Debug.Log(totalPoints);
        }
        checkIfInteractable();
    }

    void checkIfInteractable()
    {
        if (totalPoints - shieldCost < 0)
        {
            shieldButton.interactable = false; 
        }
    }
}
