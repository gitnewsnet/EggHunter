using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public static string EGGS_COUNTER = "counter";
    public static string RABBITS_COUNTER = "rabbit";

    public GameObject InfoPanel;
    public GameObject TreasureChest;

    void Start()
    {
        PlayerPrefs.DeleteKey("counter");
        PlayerPrefs.DeleteKey("rabbit");

        TreasureChest.SetActive(false);
    }

    void Update()
    {
        if (PlayerPrefs.GetInt(GameController.RABBITS_COUNTER) == 6)
        {
            TreasureChest.SetActive(true);
            InfoPanel.SetActive(true);
        }
    }

    public void closeInfoPanel()
    {
        InfoPanel.SetActive(false);
    }
}