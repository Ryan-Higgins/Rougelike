using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireTrap : MonoBehaviour {

	GameObject player;
	public player myPlayer;
	public int count;
	const float damage = .02f;
	public bool showFire;
	public GameObject objectToShow;


	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		myPlayer = player.GetComponent<player> ();
		count = 0;
	}
		
	void OnTriggerEnter2D (Collider2D entity) {
		if (entity.tag == "Player") {
			myPlayer.isBurning = true;
			//gameObject.SetActive (false);
		}
	}

	void Update() {
		if (myPlayer.isBurning == true) {
			myPlayer.health -= damage * Time.deltaTime;
			if (showFire) {
				objectToShow.SetActive (true);
			}
			count++;
		} else {
			myPlayer.isBurning = false;
			if (showFire) {
				objectToShow.SetActive (false);
			}
			count = 0;
		}

		if (!myPlayer.isBurning) {
			count = 0;
		}
	}
}
