﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfoPanelScript : MonoBehaviour
{
    public GameObject InfoPanel;
    public Text BodyInfo;

    public void openInfoPanel()
    {
        switch (PlayerPrefs.GetInt(GameController.EGGS_COUNTER))
        {
            case 0:
                BodyInfo.text = "Start your trip from the Reception";
                break;
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                BodyInfo.text = "Your score: " + PlayerPrefs.GetInt(GameController.EGGS_COUNTER);
                break;
            case 6:
                BodyInfo.text = "You Win! Try your luck on the Reception.";
                break;
        }

    //    if (PlayerPrefs.GetInt(GameController.EGGS_COUNTER) == 6 && PlayerPrefs.GetInt(GameController.RABBITS_COUNTER) == 6)
    //    {            BodyInfo.text = "You are lucky :) Get your prize on the Reception";         }

        InfoPanel.SetActive(true);
    }

    public void closeInfoPanel()
    {
        InfoPanel.SetActive(false);
    }
}