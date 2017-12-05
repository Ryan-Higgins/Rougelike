using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour {

public float rotationAmount;
public float rotationSpeed;
public Vector3 destEuler = new Vector3(0,0,0);
private Vector3 currEuler = new Vector3(0,0,0);


void Start () {

	rotationAmount = 90.0f;
	rotationSpeed = 10.0f;
	transform.eulerAngles = destEuler;
}

	void rightSwipe(){
		rotationSpeed += rotationSpeed * 3;
		destEuler.z += rotationAmount;
		destEuler.z -= rotationAmount*2;
	}

	void leftSwipe(){
		rotationSpeed += rotationSpeed * 3;
		destEuler.z -= rotationAmount;
		destEuler.z += rotationAmount*2;
	}
		

void Update () {

		//if (Input.GetKeyDown(KeyCode.Space)) {
			//destEuler.z += rotationAmount;
	//}

		if (Input.GetKeyDown (KeyCode.A)) {
			destEuler.z += rotationAmount;
			destEuler.y -= rotationAmount*4;
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			destEuler.z -= rotationAmount;
			destEuler.y -= rotationAmount*4;
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			destEuler.z += rotationAmount;
			destEuler.y -= rotationAmount*4;
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			destEuler.z -= rotationAmount;
			destEuler.y += rotationAmount*4;
		}

	currEuler = Vector3.Lerp(currEuler, destEuler, Time.deltaTime * rotationSpeed);
	transform.eulerAngles = currEuler;
	}
}

