using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomSpawn : MonoBehaviour {

	public List<GameObject> rooms;
	public List<GameObject> gameManager;
	GameObject prefabToChoose;
	bool generating;
	int count;

	// Use this for initialization
	void Start () {
		generating = true;
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (generating == true && count < 9) {
			for (int i = 0; i < gameManager.Count; i++) {
				prefabToChoose = rooms [Random.Range (0, rooms.Count)];
				prefabToChoose.transform.position = gameManager [i].transform.position;
				GameObject currentPrefab = GameObject.Instantiate (prefabToChoose, gameManager [i].transform, gameManager [i]);
				currentPrefab.transform.position = gameManager [i].transform.position;
				count = count + 1;
			}
		} else if (count >= 9) {
			generating = false;
		}
	}
}
