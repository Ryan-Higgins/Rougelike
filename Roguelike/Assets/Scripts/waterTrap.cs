using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterTrap : MonoBehaviour {

	GameObject player;
	player myPlayer;
	int count;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		myPlayer = player.GetComponent<player> ();
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (myPlayer.isWet && count < 480) {
			count += 1;
		} else {
			myPlayer.isWet = false;
			count = 0;
		}
	}

	void OnTriggerEnter2D(Collider2D entity) {
		if (entity.tag == "Player") {
			gameObject.SetActive (false);
			if (myPlayer.isBurning) {
				myPlayer.isBurning = false;
			}
			myPlayer.isWet = true;
			count = 0;
		}
	}
}
