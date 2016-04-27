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
	public  AudioSource audio;
	public float audioTime;
	public float DELTA_MUSIC_TIME;
	bool isPlaying;


	private List<GameObject> RabbitsCollection = new List<GameObject>();

	// Use this for initialization
	void Start()
	{
		audioTime = 0;
		DELTA_MUSIC_TIME = 0;
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
		audioTime -= Time.deltaTime;
		if (audioTime < 0) {
			audio.Stop();
			isPlaying = false;
			audioTime = DELTA_MUSIC_TIME;
		}
	}

	public void OnMouseDown()
	{
		int rand = Random.Range(0, RabbitsCollection.Count);
		RabbitsCollection[rand].SetActive(true);
		if (!isPlaying) {
			audio.Play ();
			isPlaying = true;
			audioTime = 15;
		} else {
			audioTime = 15;
		}
	}
}