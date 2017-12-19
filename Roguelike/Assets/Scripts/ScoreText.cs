using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {
	GameObject score;
	Score myScore;
	Text myText;

	// Use this for initialization
	void Start () {
		score = GameObject.Find ("Score");
		myScore = score.GetComponent<Score> ();

		myText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		myText.text = "Score: " + myScore.score.ToString ();
	}
}
