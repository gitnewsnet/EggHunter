using System;
using UnityEngine;
using System.Collections;

public class RabbitController : MonoBehaviour
{
    public GameObject Rabbit;
    public float timer = 15;
    float RABBIT_TIME_LIFE = 15;

    public void OnMouseDown()
    {
        Rabbit.SetActive(false);
        TakeRabbit();
    }

    void TakeRabbit()
    {
        PlayerPrefs.SetInt(GameController.RABBITS_COUNTER, PlayerPrefs.GetInt(GameController.RABBITS_COUNTER) + 1);
    }

    void Start()
    {
        gameObject.SetActive(false);
        PlayerPrefs.DeleteKey("rabbit");
    }
    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            gameObject.SetActive(false);
			timer = RABBIT_TIME_LIFE;
        }
        
    }
}