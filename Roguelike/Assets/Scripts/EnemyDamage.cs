using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

	GameObject player;
	player myPlayer;
	public bool test = false;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		myPlayer = player.GetComponent<player> ();
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D coll) {

		if (coll.gameObject.tag == "Player") {

			test = true;

			myPlayer.health -= 2;
			gameObject.SetActive (false);

		}
	}
}
