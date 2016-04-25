using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EasterEgg : MonoBehaviour
{
    public GameObject EasterRabbit0;
    public GameObject EasterRabbit1;
    public GameObject EasterRabbit2;
    public GameObject EasterRabbit3;
    public GameObject EasterRabbit4;
    public GameObject EasterRabbit5;
    public GameObject Egg;

    RabbitController rContrl;

    private List<GameObject> RabbitsCollection = new List<GameObject>();

    // Use this for initialization
    void Start()
    {
        RabbitsCollection.Add(EasterRabbit0);
        RabbitsCollection.Add(EasterRabbit1);
        RabbitsCollection.Add(EasterRabbit2);
        RabbitsCollection.Add(EasterRabbit3);
        RabbitsCollection.Add(EasterRabbit4);
        RabbitsCollection.Add(EasterRabbit5);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        int rand = Random.Range(0, RabbitsCollection.Count);
        Debug.Log(rand);
        //	int i = rand;
        Debug.Log(RabbitsCollection[rand].activeInHierarchy);
        if (RabbitsCollection[rand].activeInHierarchy == false)
        {
            RabbitsCollection[rand].SetActive(true);
        }

        /*     if (PlayerPrefs.GetInt(GameController.EGGS_COUNTER) == 6)
             {
                 Egg.SetActive(false);

                 foreach (var rabbit in RabbitsCollection)
                 {
                     rabbit.SetActive(true);
                 }
             }*/
    }
}