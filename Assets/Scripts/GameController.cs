using UnityEngine;
using System.Collections;
using System;

public class GameController : MonoBehaviour
{
    public static string EGGS_COUNTER = "counter";
    public static string GAME_STATUS = "status"; //0- start game 1 - at least one egg has collected 2- all eggs are collected 3- easter egg has found
	public static int RABBITS = 6;
	public static string START_DAY = "start_day";

    public GameObject InfoPanel;
    public GameObject TreasureChest;

    void Start()
    {        
		//PlayerPrefs.DeleteKey(GAME_STATUS);
		if (PlayerPrefs.GetInt(GameController.GAME_STATUS)==3) TreasureChest.SetActive(true);
		resetGame(PlayerPrefs.GetInt (START_DAY)); 
    }

    public void closeInfoPanel()
    {
        InfoPanel.SetActive(false);
    }

	private  IList eggsName = new ArrayList(){"Egg_E1", "Egg_A", "Egg_S", "Egg_T", "Egg_E2", "Egg_R"};
	public void resetGame(){
		int result = 0;
		PlayerPrefs.SetInt (GameController.GAME_STATUS, result);
		PlayerPrefs.SetInt (GameController.EGGS_COUNTER, result);
		foreach(string egg in eggsName){
			PlayerPrefs.SetInt (egg, result);
		}
		Debug.Log ("RESET");
	}

	public void resetGame(int gameDay){
		DateTime today = DateTime.Today;
		if (gameDay != today.Day) {
				resetGame ();
		}
		PlayerPrefs.SetInt (START_DAY, today.Day);
	}
}