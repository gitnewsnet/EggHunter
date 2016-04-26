using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public static string EGGS_COUNTER = "counter";
    public static string RABBITS_COUNTER = "rabbit";
	public static int RABBITS = 6;

    public GameObject InfoPanel;
    public GameObject TreasureChest;

    void Start()
    {        
		PlayerPrefs.DeleteKey(RABBITS_COUNTER);
		TreasureChest.SetActive(false);
    }

    void Update()
    {
      //  if (PlayerPrefs.GetInt(GameController.RABBITS_COUNTER) == 6)
      //  {            TreasureChest.SetActive(true);
      //      InfoPanel.SetActive(true);          }
    }

    public void closeInfoPanel()
    {
        InfoPanel.SetActive(false);
    }

	private  IList eggsName = new ArrayList(){"Egg_E1", "Egg_A", "Egg_S", "Egg_T", "Egg_E2", "Egg_R"};
	public void resetGame(){
		int result = 0;
		PlayerPrefs.SetInt (GameController.RABBITS_COUNTER, result);
		foreach(string egg in eggsName){
			PlayerPrefs.SetInt (egg, result);
		}
	}

}