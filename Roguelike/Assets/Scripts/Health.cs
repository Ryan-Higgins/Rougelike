using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
	GameObject player;
	player myPlayer;
	Text myText;

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
		myText.text = "Health: " + myPlayer.health.ToString ();
	}
}
