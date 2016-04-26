using System;
using UnityEngine;
using System.Collections;

public class RabbitController : MonoBehaviour
{
    public GameObject Rabbit;
    public float timer = 15;
    float RABBIT_TIME_LIFE = 15;
	private bool isPressed = false;
	public GameObject InfoPanel;

    public void OnMouseDown()
    {
        Rabbit.SetActive(false);
        TakeRabbit();
		if (PlayerPrefs.GetInt (GameController.EGGS_COUNTER) == 6 && PlayerPrefs.GetInt (GameController.RABBITS_COUNTER) >= GameController.RABBITS) {
		 	InfoPanel.SetActive (true);
		}
    }

    void TakeRabbit()
    {
		if (!isPressed) {
			PlayerPrefs.SetInt (GameController.RABBITS_COUNTER, PlayerPrefs.GetInt (GameController.RABBITS_COUNTER) + 1);
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
		timer -= Time.deltaTime;
		if (timer < 0)
		{
			isPressed = false;
			gameObject.SetActive(false);
			timer = RABBIT_TIME_LIFE;
		}      
	}
}