using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPrefabGenerator : MonoBehaviour {

	public List<GameObject> thingsToGenerate;
	GameObject randomPrefab;
	// Use this for initialization
	void Start () {
		randomPrefab = thingsToGenerate[Random.Range(0, thingsToGenerate.Count)];
		GameObject.Instantiate (randomPrefab, gameObject.transform);
	}
	

}
