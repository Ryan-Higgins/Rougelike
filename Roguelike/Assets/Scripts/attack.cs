using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour {
	public bool check;
	GameObject player;
	player myPlayer;

	void Start () {
		player = GameObject.Find ("Player");
		myPlayer = player.GetComponent<player> ();
	}

	void OnTriggerStay2D (Collider2D enemy) {
		check = true;
		if (Input.GetKey (KeyCode.Space)) {
			Destroy (gameObject);
			myPlayer.enemiesKilled += 1;
		}
		
	}
}
