using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {
	public float health;
	public bool isBurning;
	public bool isWet;
	public int enemiesKilled;
	public Text enemyText;
	public Text trapdoorText;
	public bool loadScene; 
	public string sceneToLoad;

	// Use this for initialization
	void Start () {
		health = 10f;	
		isBurning = false;
		isWet = false;
	}

	void Update () {
		if (health <= 0) {
			if (loadScene) {
				SceneManager.LoadScene (sceneToLoad);

			}
		}
	}
}
