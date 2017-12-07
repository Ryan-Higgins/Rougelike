using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float speed;
	Rigidbody2D myRB;
	float h;
	float v;

	void Start() {
		myRB = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate() {

		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (h, v);
		myRB.AddForce (movement * speed);

		if (Input.GetKey (KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
			transform.rotation = Quaternion.Euler (0, 0, 90);
		} else if (Input.GetKey (KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
			transform.rotation = Quaternion.Euler (0, 0, 270);
		} else if (Input.GetKey (KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
			transform.rotation = Quaternion.Euler (0, 0, 0);
		} else if (Input.GetKey (KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
			transform.rotation = Quaternion.Euler(0,0,180);
		}
	}
}