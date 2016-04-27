using UnityEngine;
using System.Collections;

public class ButtonImage : MonoBehaviour {

	public Sprite layer, layerPressed;

	void OnMouseDown(){
		GetComponent<SpriteRenderer> ().sprite = layerPressed;
	}

	void OnMouseUp(){
		GetComponent<SpriteRenderer> ().sprite = layer;
	}
}
