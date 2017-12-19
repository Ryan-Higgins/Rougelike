using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapDoor : MonoBehaviour {
	public string sceneToLoad;
	GameObject player;
	player myPlayer;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		myPlayer = player.GetComponent<player> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D player) {
		if (myPlayer.enemiesKilled >= 5) {
			SceneManager.LoadScene (sceneToLoad);
		}
	}
}
