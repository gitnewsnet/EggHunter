using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfoPanelScript : MonoBehaviour
{
    public GameObject InfoPanel;
    public Text BodyInfo;
	public GameObject GameControl;

    public void openInfoPanel()
    {
        switch (PlayerPrefs.GetInt(GameController.GAME_STATUS))
        {
            case 0:
                BodyInfo.text = "Start your trip from the Reception";  
                break;
            case 1:
                BodyInfo.text = "Your score: " + PlayerPrefs.GetInt(GameController.EGGS_COUNTER);
                break;
            case 2:
                BodyInfo.text = "You Win! Try your luck on the Reception";
                break;
            case 3:
			    BodyInfo.text = "You are lucky!\n  You've found secret Easter EGG!\n Let's go to the Reception";        				
	            break;
        }
        InfoPanel.SetActive(true);
    }

    public void closeInfoPanel()
    {
        InfoPanel.SetActive(false);
    }
}