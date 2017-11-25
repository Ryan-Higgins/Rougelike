using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireTrap : MonoBehaviour {

	GameObject player;
	public player playerHealth;



	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		playerHealth = player.GetComponent<player> ();
	}

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D entity) {
		if (entity.tag == "Player") {
			playerHealth.health -= 1;
			gameObject.SetActive (false);
		}
	}
}
