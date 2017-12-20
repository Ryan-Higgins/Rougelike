using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pressEnter : MonoBehaviour {

	//Input.GetKey (KeyCode.Return);
	public KeyCode enterKey = KeyCode.Return;
	public bool loadScene; 
	public string sceneToLoad;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(enterKey)) {
			if (loadScene) {
				SceneManager.LoadScene (sceneToLoad);
			}
		}
	}
}
