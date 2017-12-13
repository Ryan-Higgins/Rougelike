using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

	GameObject player;
	public player myPlayer;
	public bool test;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		myPlayer = player.GetComponent<player> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D player) {
		myPlayer.hasKey = true;
		gameObject.SetActive (false);
		test = true;
	}
}
