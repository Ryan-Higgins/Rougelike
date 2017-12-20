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
	Animator anim;



	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
		direction = 1;
		speedSet = Random.value;
		count = 0;

		if (speedSet <= 0.5f) {
			xSpeed = Random.Range (-6f, 6f);
		} else if (speedSet >= 0.5f) {
			ySpeed = Random.Range (-6f, 6f);
		}

		anim = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3 (xSpeed * direction, ySpeed * direction);
		myRigidBody.AddForce (move);

		if (count > 240) {
			count = 0;
			direction *= -1;
			Vector3 changeScale = transform.localScale;
			changeScale.y *= -1;
			transform.localScale = changeScale;
		} else { 
			count++;
		}

		//stab = Input.GetKey (KeyCode.Space);
	}
}
