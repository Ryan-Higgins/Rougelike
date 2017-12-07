using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowIfClose : MonoBehaviour {

	public float xSpeed;
	public float ySpeed;
	public int direction;
	public float speedSet;
	//Rigidbody2D myRigidBody;
	int count;

	public Rigidbody2D RbPlayer;
	Rigidbody2D myrigidbody;
	//float currentSpeed;

	//public float enemyMinSpeed;
	public float minimumPlayerDistance;

	float playerPositionDistanceX;
	float playerPositionDistanceY;

	void Start()
	{
		myrigidbody = GetComponent<Rigidbody2D> ();
		direction = 1;
		speedSet = Random.value;
		count = 0;

		if (speedSet <= 0.5f) {
			xSpeed = Random.Range (-2f, 2f);
		} else if (speedSet >= 0.5f) {
			ySpeed = Random.Range (-2f, 2f);
		}

		//myrigidbody = GetComponent<Rigidbody2D>();
		//currentSpeed = myrigidbody.velocity.x;
	}

	void FixedUpdate ()
	{

		playerPositionDistanceX = (Mathf.Abs (myrigidbody.position.x - RbPlayer.position.x));
		playerPositionDistanceY = (Mathf.Abs (myrigidbody.position.y - RbPlayer.position.y));

		if (playerPositionDistanceX >= minimumPlayerDistance || playerPositionDistanceY >= minimumPlayerDistance) {

			Vector3 move = new Vector3 (xSpeed * direction, ySpeed * direction);
			myrigidbody.AddForce (move);

			if (count > 240) {
				count = 0;
				direction *= -1;
			} else { 
				count++;
			}
		} 

		else if (playerPositionDistanceX < minimumPlayerDistance || playerPositionDistanceY < minimumPlayerDistance){
			
			Vector3 pos = Vector3.MoveTowards (transform.position, RbPlayer.position, speedSet * Time.deltaTime);
			//GetComponent<Rigidbody2D> ().MovePosition (pos);
			myrigidbody.MovePosition (pos);

		}
			
	}

}
