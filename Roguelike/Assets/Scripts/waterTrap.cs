using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterTrap : MonoBehaviour {

	GameObject player;
	player myPlayer;
	int count;
	public bool showWater;
	public GameObject objectToShow;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		myPlayer = player.GetComponent<player> ();
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (myPlayer.isWet && count < 80) {
			if (showWater) {
				objectToShow.SetActive (true);
			}
			count += 1;
		} else {
			if (showWater) {
				objectToShow.SetActive (false);
			}
			myPlayer.isWet = false;
			count = 0;
		}
	}

	void OnTriggerEnter2D(Collider2D entity) {
		if (entity.tag == "Player") {
			//gameObject.SetActive (false);
			if (myPlayer.isBurning) {
				myPlayer.isBurning = false;
			}
			myPlayer.isWet = true;
			count = 0;
		}
	}
}
