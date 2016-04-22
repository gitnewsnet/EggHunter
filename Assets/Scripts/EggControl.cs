using UnityEngine;
using System.Collections;

public class EggControl : MonoBehaviour {

	public Sprite empty, eggChar;

	// Use this for initialization
	void Start () {
		setUpEgg ();
	}
	
	public void setUpEgg(){
		
		if (PlayerPrefs.GetInt (gameObject.name) == 0) {
			GetComponent<SpriteRenderer> ().sprite = empty;
		} else {
			GetComponent<SpriteRenderer> ().sprite = eggChar;
		}
	}
}
