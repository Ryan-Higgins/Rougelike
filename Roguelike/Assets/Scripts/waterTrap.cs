using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterTrap : MonoBehaviour {

	GameObject player;
	player myPlayer;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		myPlayer = player.GetComponent<player> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D entity) {
		if (entity.tag == "Player") {
			gameObject.SetActive (false);
			if (myPlayer.isBurning) {
				myPlayer.isBurning = false;
			}
			myPlayer.isWet = true;
		}
	}
}
