using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour {

	public GameObject infoPanel;
	public Text bodyInfo;


	public void openInfoPanel(){
		switch(PlayerPrefs.GetInt(GameCntr.COUNTER)){
		case 0:
			bodyInfo.text = "Let's play";	
			break;
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
			bodyInfo.text = "Your score: " + PlayerPrefs.GetInt (GameCntr.COUNTER);
			break;
		case 6:
			bodyInfo.text = "YOU WIN";
			break;
		}

		infoPanel.SetActive (true);
	}

	public void closeInfoPanel(){
		infoPanel.SetActive (false);
	}
}
