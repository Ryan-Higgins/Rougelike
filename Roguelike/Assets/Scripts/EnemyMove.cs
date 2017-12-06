using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	public float xSpeed;
	public float ySpeed;
	public int direction;
	public float speedSet;
	Rigidbody2D myRigidBody;
	int count;

	RaycastHit2D up;
	RaycastHit2D down;
	RaycastHit2D left;
	RaycastHit2D right;
	int rayLength = 1;


	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
		direction = 1;
		speedSet = Random.value;
		count = 0;

		if (speedSet <= 0.5f) {
			xSpeed = Random.Range (-2f, 2f);
		} else if (speedSet >= 0.5f) {
			ySpeed = Random.Range (-2f, 2f);
		}

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3 (xSpeed * direction, ySpeed * direction);
		myRigidBody.AddForce (move);

		up = Physics2D.Raycast (transform.position, Vector2.up, rayLength);
		down = Physics2D.Raycast (transform.position, Vector2.down, rayLength);
		right = Physics2D.Raycast (transform.position, Vector2.right, rayLength);
		left = Physics2D.Raycast (transform.position, Vector2.left, rayLength);

		if (xSpeed > 0 && left || right) {
			direction *= -1;
		}

		if (ySpeed > 0 && up || down) {
			direction *= -1;
		}

		if (count > 240) {
			count = 0;
			direction *= -1;
		} else { 
			count++;
		}
	}
}
