using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapDoorText : MonoBehaviour {
	GameObject player;
	player myPlayer;
	public Text myText;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		myPlayer = player.GetComponent<player> ();

		myText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (myPlayer.enemiesKilled >= 5) {
			myText.text = "Trapdoor Open";
		}
	}
}
