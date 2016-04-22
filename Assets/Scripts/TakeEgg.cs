using UnityEngine;
using System.Collections;

public class TakeEgg : MonoBehaviour {

public GameObject txt;
		public void OnMouseDown(){		
		txt.SetActive (true);
		gameObject.SetActive (false);
	
		}
}

