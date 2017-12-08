using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public float health;
	public bool isBurning;
	public bool isWet;

	// Use this for initialization
	void Start () {
		health = 10f;	
		isBurning = false;
		isWet = false;
	}
}
