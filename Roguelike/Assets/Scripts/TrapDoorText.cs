using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapDoorText : MonoBehaviour {
	GameObject player;
	player myPlayer;
	public Text myText;
	public GameObject objectToShow;
	public bool showObject;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		myPlayer = player.GetComponent<player> ();

		myText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		player = GameObject.Find ("Player");
		myPlayer = player.GetComponent<player> ();
		if (myPlayer.enemiesKilled >= 10) {
			if (showObject) {
				objectToShow.SetActive (true);
			}
			myText.text = "Trapdoor Open";

		} else {
			myText.text = "";
		}
	}
}
