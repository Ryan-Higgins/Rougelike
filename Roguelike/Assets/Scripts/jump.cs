using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {
	public bool groundCheck;
	public Rigidbody2D rb;
	public float jumpForce = 100f;

	// Use this for initialization
	void Start () {
		rb = GetComponentInParent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		groundCheck = true;

	}

	void update() {
		if (groundCheck == true) { 
			if (Input.GetKey (KeyCode.W)) {
				rb.AddForce (new Vector2 (0, jumpForce));
			}
		}
	}
}
