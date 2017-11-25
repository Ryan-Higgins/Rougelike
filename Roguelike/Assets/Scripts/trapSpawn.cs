using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapSpawn : MonoBehaviour {
	public List<GameObject> spawns;
	public List<GameObject> traps;
	GameObject trapToChose;
	bool generating;
	int count;

	// Use this for initialization
	void Start () {
		generating = true;
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (generating = true && count < 2) {
			for (int i = 0; i < spawns.Count; i++) {
				trapToChose = traps[Random.Range(0,traps.Count)];
				trapToChose.transform.position = spawns [i].transform.position;
				GameObject currentTrap = GameObject.Instantiate (trapToChose, spawns [i].transform, spawns [i]);
				currentTrap.transform.position = spawns [i].transform.position;
				count = count + 1;
			}
		}
	}
}
