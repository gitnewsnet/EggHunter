﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfoPanelScript : MonoBehaviour
{
    public GameObject InfoPanel;
    public Text BodyInfo;
	public GameObject GameControl;
	public  AudioSource audio;

    public void openInfoPanel()
    {
        switch (PlayerPrefs.GetInt(GameController.GAME_STATUS))
        {
            case 0:
                BodyInfo.text = "Start your trip from the Reception";  
                break;
            case 1:
                BodyInfo.text = "Your have collected: " + PlayerPrefs.GetInt(GameController.EGGS_COUNTER) + " from 6";
                break;
			case 2:
				BodyInfo.text = "You Won! Try your luck at the Reception";
				audio.Play();
                break;
            case 3:
			    BodyInfo.text = "You are lucky!\n  You've found secret Easter EGG!\n Let's go to the Reception"; 
				audio.Play();
	            break;
        }


        InfoPanel.SetActive(true);
    }

    public void closeInfoPanel()
    {
        InfoPanel.SetActive(false);
		audio.Stop();
    }
}