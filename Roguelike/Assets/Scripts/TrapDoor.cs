using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapDoor : MonoBehaviour {
	public string sceneToLoad;
	GameObject player;
	player myPlayer;
	GameObject score;
	Score myScore;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		myPlayer = player.GetComponent<player> ();

		score = GameObject.Find ("Score");
		myScore = score.GetComponent<Score> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D player) {
		if (myPlayer.enemiesKilled >= 5) {
			SceneManager.LoadScene (sceneToLoad);
			myPlayer.enemiesKilled = 0;
		}
	}
}
