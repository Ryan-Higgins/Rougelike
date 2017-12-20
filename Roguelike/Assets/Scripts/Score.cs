using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public float score;
	public Text scoreText;
	public int multiplier;
	public GameObject canvas;
	GameObject canvasCopy;
	int count;


	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);

		if (FindObjectsOfType (GetType ()).Length > 1) {
			Destroy (gameObject);
		}

		count = 0;
		score = 0;
		multiplier = 1;
		canvasCopy = canvas;
		if (count < 1) {
			GameObject.Instantiate (canvasCopy);
		}
	}
	
	// Update is called once per frame
	void Update () {
		score +=  Time.deltaTime;
		score *= multiplier;
		if 
	}
}
