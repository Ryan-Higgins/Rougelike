using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour {
	public bool check;

	void Start () {
		
	}

	void OnTriggerStay2D (Collider2D enemy) {
		check = true;
		if (Input.GetKey (KeyCode.Space)) {
			Destroy (gameObject);
		}
	}
}
