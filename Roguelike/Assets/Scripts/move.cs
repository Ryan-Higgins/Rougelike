using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	private float speed = 2.0f;
	private Vector3 pos;
	private Transform tr;

	void Start() {
		pos = transform.position;
		tr = transform;
	}

	void Update() {

		if (Input.GetKeyDown (KeyCode.D) && tr.position == pos) {
			pos += Vector3.right;
		} else if (Input.GetKeyDown (KeyCode.A)) {
			pos += Vector3.left;
		} else if (Input.GetKeyDown (KeyCode.W)) {
			pos += Vector3.up;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			pos += Vector3.down;
		} 
		transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
	}
}