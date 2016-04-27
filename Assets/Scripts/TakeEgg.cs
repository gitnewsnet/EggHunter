using UnityEngine;
using System.Collections;

public class TakeEgg : MonoBehaviour
{
    public GameObject txt;
    public GameObject eggSprite;
	public GameObject InfoPanel;
	public  AudioSource audio;

    private void Start()
    {
        if (PlayerPrefs.GetInt(eggSprite.name) == 1)
        {
            txt.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    public void OnMouseDown()
    {
        txt.SetActive(true);
        gameObject.SetActive(false);
        saveEgg();
		audio.Play ();
    }

    public void saveEgg()
    {
        PlayerPrefs.SetInt(eggSprite.name, 1);    
        PlayerPrefs.SetInt(GameController.EGGS_COUNTER, PlayerPrefs.GetInt(GameController.EGGS_COUNTER)+1);
		if (PlayerPrefs.GetInt (GameController.EGGS_COUNTER) == 6) {
			PlayerPrefs.SetInt (GameController.GAME_STATUS, 2);
			InfoPanel.GetComponent<InfoPanelScript>().openInfoPanel();	
		}else
            PlayerPrefs.SetInt(GameController.GAME_STATUS, 1);

        eggSprite.GetComponent<SpriteRenderer>().sprite = eggSprite.GetComponent<EggControl>().eggChar;
    }
}