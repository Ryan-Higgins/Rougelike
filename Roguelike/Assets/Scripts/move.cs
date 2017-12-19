using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float speed;
	Rigidbody2D myRB;
	float h;
	float v;
	Animator anim;
	bool wait = false;
	bool stop = false;
	bool stab;
	public bool showObject;
	public GameObject objectToShow;
	GameObject player;
	player myPlayer;

	void Start() {
		myRB = GetComponent<Rigidbody2D> ();
		anim = GetComponentInChildren<Animator>();
		//StartCoroutine(WaitCoroutine());
		player = GameObject.Find("Player");
		myPlayer = player.GetComponent<player> ();
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Wall" && stab == true){
			//anim.SetBool ("attackEnemy", false);

		}
	}

	void FixedUpdate() {

		stab = Input.GetKey (KeyCode.Space);

		if (stab == true) {
			anim.SetBool ("attackEnemy", true);
			if(showObject){
				objectToShow.SetActive (true);
			}
		}
		if (stab == false) {
			anim.SetBool ("attackEnemy", false);
			if(showObject){
				objectToShow.SetActive (false);
			}
		}

		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (h, v);
		myRB.AddForce (movement * speed);

		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			anim.SetBool ("walk", true);
			transform.rotation = Quaternion.Euler (0, 0, 90);
		} else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			anim.SetBool ("walk", true);
			transform.rotation = Quaternion.Euler (0, 0, 270);
		} else if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			anim.SetBool ("walk", true);
			transform.rotation = Quaternion.Euler (0, 0, 0);
		} else if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			anim.SetBool ("walk", true);
			transform.rotation = Quaternion.Euler (0, 0, 180);
		} else {
			anim.SetBool ("walk", false);
		}
	}

	/*IEnumerator WaitCoroutine()
	{
		if (wait == true) {
			yield return new WaitForSeconds (2f);
			stop = true;
		}
	}*/
}