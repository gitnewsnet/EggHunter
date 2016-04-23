using UnityEngine;
using System.Collections;

public class TakeEgg : MonoBehaviour {

	public GameObject txt;
	public GameObject eggSprite;

	void Start(){
		if (PlayerPrefs.GetInt (eggSprite.name) == 1) {
			txt.SetActive (true);
			gameObject.SetActive (false);
		}
	}

	public void OnMouseDown(){		
		txt.SetActive (true);
		gameObject.SetActive (false);
		saveEgg ();
	}
				
	public void saveEgg(){
		PlayerPrefs.SetInt (eggSprite.name, 1);
		eggSprite.GetComponent<SpriteRenderer> ().sprite = eggSprite.GetComponent<EggControl> ().eggChar;
		PlayerPrefs.SetInt (GameCntr.COUNTER, PlayerPrefs.GetInt (GameCntr.COUNTER)+1);
	}
}

