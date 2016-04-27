using System;
using UnityEngine;
using System.Collections;

public class RabbitController : MonoBehaviour
{
    public static int sRabbitCounter = 0; 
    public GameObject Rabbit;
    public float RabbitLifeTimer = 15;
    static float RABBIT_TIME_LIFE = 15;
	private bool isPressed = false;
	public GameObject InfoPanel;

    public void OnMouseDown()
    {
        Rabbit.SetActive(false);
        TakeRabbit();
		Debug.Log ("GAME Starus:  "+PlayerPrefs.GetInt (GameController.GAME_STATUS));
		Debug.Log ("sRabbitCounter:  "+sRabbitCounter);
		if (PlayerPrefs.GetInt (GameController.GAME_STATUS) == 2 && sRabbitCounter >= GameController.RABBITS) {
            PlayerPrefs.SetInt(GameController.GAME_STATUS, 3);
			InfoPanel.GetComponent<InfoPanelScript>().openInfoPanel();
			InfoPanel.GetComponent<InfoPanelScript>().GameControl.GetComponent<GameController> ().TreasureChest.SetActive (true);

		}
      
    }

    void TakeRabbit()
    {
		if (!isPressed&&PlayerPrefs.GetInt (GameController.GAME_STATUS) == 2) {
            sRabbitCounter++;
			isPressed = true;
		}
    }

    void Start()
    {
        gameObject.SetActive(false);
        //PlayerPrefs.DeleteKey("rabbit");
    }
    public void Update()
    {
		timerControl ();
    }

	private void timerControl(){
		RabbitLifeTimer -= Time.deltaTime;
		if (RabbitLifeTimer < 0)
		{
			if (isPressed) {
                sRabbitCounter--;
			}
			isPressed = false;
			gameObject.SetActive(false);
			RabbitLifeTimer = RABBIT_TIME_LIFE;
		}      
	}
}