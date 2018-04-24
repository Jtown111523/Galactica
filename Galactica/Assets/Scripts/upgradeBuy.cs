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

    public Text totalPointsText;

    public Text costText;

    audioManager Audio;

    private void Awake()
    {
        totalPoints = PlayerPrefs.GetInt("totalScore");
        shieldCount = PlayerPrefs.GetInt("ShieldCount");
        numberText.text = "Currently Owned: " + PlayerPrefs.GetInt("ShieldCount").ToString("0");
        checkIfInteractable();
        totalPointsText.text = "Spending Points: " + totalPoints.ToString("0");
        costText.text = "Cost: " + shieldCost.ToString("0");

        Audio = FindObjectOfType<audioManager>();
    }

    public void buyShield()
    {
        if (totalPoints - shieldCost >= 0)
        {
            //subtract cost from the total points
            totalPoints = PlayerPrefs.GetInt("totalScore");
            totalPoints = totalPoints - shieldCost;
            PlayerPrefs.SetInt("totalScore", totalPoints);
            totalPointsText.text = "Spending Points: " + totalPoints.ToString("0");

            //add to shield count
            shieldCount = PlayerPrefs.GetInt("ShieldCount");
            shieldCount++;
            PlayerPrefs.SetInt("ShieldCount", shieldCount);

            //display new # owned on bottom

            numberText.text = "Currently Owned: " + PlayerPrefs.GetInt("ShieldCount").ToString("0");

            //Debug.Log(totalPoints);
        }
        checkIfInteractable();
        Audio.Play("Upgrade");
    }

    void checkIfInteractable()
    {
        if (totalPoints - shieldCost < 0)
        {
            shieldButton.interactable = false; 
        }
    }
}
