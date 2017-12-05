using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpRaySingleMove : MonoBehaviour {

		//public float speed = 2.0f;
		//public float rayLength;
		//public float whenToStop = 1f;

		public LayerMask myMask;

		private int speed = (Mathf.Clamp (2,1,3));
		private int rayLength = 1;
		private int whenToStop = (Mathf.Clamp (1,0,2));

		bool wayIsBlockedRight;
		bool wayIsBlockedLeft;
		bool wayIsBlockedUp;
		bool wayIsBlockedDown;

		private int distanceToMove = (Mathf.Clamp (1,0,2));
		public float timeTakenDuringLerp;// = (Mathf.Clamp (.75,.5f,1.0f));

		//public float distanceToMove = 1f;
		//public float timeTakenDuringLerp = 1f;

		private bool _isLerping;
		private Vector3 _startPosition;
		private Vector3 _endPosition;
		private float _timeStartedLerping;


		void StartLerpingUp()
		{
			_isLerping = true;
			_timeStartedLerping = Time.time;
			_startPosition = transform.position;
			_endPosition = transform.position + Vector3.up;//*distanceToMove;

		}

		void StartLerpingDown()
	{
		_isLerping = true;
		_timeStartedLerping = Time.time;
		_startPosition = transform.position;
		_endPosition = transform.position + Vector3.down;//*distanceToMove;

		}

		void StartLerpingLeft()
		{
			_isLerping = true;
			_timeStartedLerping = Time.time;
			_startPosition = transform.position;
			_endPosition = transform.position + Vector3.left;//*distanceToMove;

		}

		void StartLerpingRight()
		{
			_isLerping = true;
			_timeStartedLerping = Time.time;
			_startPosition = transform.position;
			_endPosition = transform.position + Vector3.right;//*distanceToMove;

		}


		void FixedUpdate()
	{
		if (_isLerping) {
			float timeSinceStarted = Time.time - _timeStartedLerping;
			float percentageComplete = timeSinceStarted / timeTakenDuringLerp;
			transform.position = Vector3.Lerp (_startPosition, _endPosition, percentageComplete);
			if (percentageComplete >= 1.0f) {
				_isLerping = false;
			}
		}


		if (wayIsBlockedUp == false) {
			noWallUp ();
		}

		if (wayIsBlockedDown == false) {
			noWallDown ();
		}

		if (wayIsBlockedRight == false) {
			noWallRight ();
		}

		if (wayIsBlockedLeft == false) {
			noWallLeft ();
		}

		Debug.DrawRay (transform.position, Vector2.up * rayLength);
		Debug.DrawRay (transform.position, Vector2.right * rayLength);
		Debug.DrawRay (transform.position, Vector2.down * rayLength);
		Debug.DrawRay (transform.position, Vector2.left * rayLength);

		// Declare hit variables for all directions
		RaycastHit2D contactAbove;
		RaycastHit2D contactBelow;
		RaycastHit2D contactLeft;
		RaycastHit2D contactRight;

		// Cast a ray in each direction and save it to a hit variable
		contactAbove = Physics2D.Raycast (transform.position, Vector2.up, rayLength, myMask);
		contactBelow = Physics2D.Raycast (transform.position, Vector2.down, rayLength, myMask);
		contactLeft = Physics2D.Raycast (transform.position, Vector2.left, rayLength, myMask);
		contactRight = Physics2D.Raycast (transform.position, Vector2.right, rayLength, myMask);


		if (contactAbove) {
			print (contactAbove.transform.tag);
			wayIsBlockedUp = true;
			noMoveUpAhead ();
		}

		if (contactBelow) {
			print (contactBelow.transform.tag);
			wayIsBlockedDown = true;
			noMoveDownTheRoad ();
		}
			
		if (contactLeft) {
			print (contactLeft.transform.tag);
			wayIsBlockedLeft = true;
			noMoveLeft ();
		}

		if (contactRight) {
			print (contactRight.transform.tag);
			wayIsBlockedRight = true;
			noMoveRight ();
		}

					
				
			

	}

			/*RaycastHit contactBelow;
			Ray isThereAWallBelow = new Ray (transform.position, Vector3.down * rayLength);

			if (Physics.Raycast (isThereAWallBelow, out contactBelow, whenToStop)) {

				if (contactBelow.collider.tag == "wall") {

					wayIsBlockedDown = true;
					noMoveDownTheRoad ();
				}
			}

			RaycastHit contactRight;
			Ray isThereAWallRight = new Ray (transform.position, Vector3.right * rayLength);

			if (Physics.Raycast (isThereAWallRight, out contactRight, whenToStop)) {

				if (contactRight.collider.tag == "wall") {

					wayIsBlockedRight = true;
					noMoveRight ();
				}
			}

			RaycastHit contactLeft;
			Ray isThereAWallLeft = new Ray (transform.position, Vector3.left * rayLength);

			if (Physics.Raycast (isThereAWallLeft, out contactLeft, whenToStop)) {

				if (contactLeft.collider.tag == "wall") {

					wayIsBlockedLeft = true;
					noMoveLeft ();
				}
			}


		}*/

		void noWallUp(){
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				transform.rotation = Quaternion.Euler(0,0,0);
				StartLerpingUp();//transform.Translate (Vector3.up);
				wayIsBlockedDown = false;
				wayIsBlockedLeft = false;
				wayIsBlockedRight = false;
			}
		}

		void noWallRight(){
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				transform.rotation = Quaternion.Euler(0,0,270);
				StartLerpingRight();//transform.Translate (Vector3.right);
				wayIsBlockedUp = false;
				wayIsBlockedLeft = false;
				wayIsBlockedDown = false;

			}
		}
		void noWallDown(){
			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				transform.rotation = Quaternion.Euler(0,0,180);
				StartLerpingDown();//transform.Translate (Vector3.down);
				wayIsBlockedUp = false;
				wayIsBlockedLeft = false;
				wayIsBlockedRight = false;
			}
		}
		void noWallLeft(){
			if (Input.GetKeyDown(KeyCode.LeftArrow)){
				transform.rotation = Quaternion.Euler(0,0,90);
				StartLerpingLeft();//transform.Translate  (Vector3.left);
				wayIsBlockedRight = false;
				wayIsBlockedUp = false;
				wayIsBlockedDown = false;
			}
		}



		void noMoveUpAhead()
		{
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				Debug.Log ("Up wall hit");
				wayIsBlockedDown = false;
				wayIsBlockedLeft = false;
				wayIsBlockedRight = false;
			}
		}

		void noMoveDownTheRoad()
		{
			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				Debug.Log ("Down wall hit");
				wayIsBlockedUp = false;
				wayIsBlockedLeft = false;
				wayIsBlockedRight = false;
			}
		}
		void noMoveRight()
		{
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				Debug.Log ("Right wall hit");
				
				//wayIsBlockedRight = false;
				
				wayIsBlockedUp = false;
				wayIsBlockedLeft = false;
				wayIsBlockedDown = false;
			}
		}

		void noMoveLeft()
		{
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				Debug.Log ("Left wall hit");
				wayIsBlockedRight = false;
				wayIsBlockedUp = false;
				wayIsBlockedDown = false;
			}
		}
		
	}
