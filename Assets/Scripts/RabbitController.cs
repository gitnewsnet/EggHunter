using System;
using UnityEngine;
using System.Collections;

public class RabbitController : MonoBehaviour
{
    public GameObject Rabbit;

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
        PlayerPrefs.DeleteKey("rabbit");
    }
}