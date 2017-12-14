using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {
	public float health;
	public bool isBurning;
	public bool isWet;
	public Text healthText;
	public int enemiesKilled;
	public Text enemyText;
	public Text trapdoorText;

	// Use this for initialization
	void Start () {
		health = 10f;	
		isBurning = false;
		isWet = false;
	}

	void Update () {
		healthText.text = "Health: " + health.ToString ();
		enemyText.text = "Enemies Killed: " + enemiesKilled.ToString ();
		if (enemiesKilled >= 5) {
			trapdoorText.text = "Trapdoor Open";
		}
	}
}
