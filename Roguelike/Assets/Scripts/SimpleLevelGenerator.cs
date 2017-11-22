using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLevelGenerator : MonoBehaviour {
	public int desiredLevelLength; // how long the level should be
	public GameObject startLevelPrefab; //where the level will start - this will also be the parent for the generated prefabs
	public GameObject Instantiator; // a gameobject that will move and generate the prefabs
	public List<GameObject> LevelPrefabs; // a list of all the prefabs
	public GameObject EndLevelPrefab; //a "cap" prefab to finish off the level - think of an end door
	public float generateSpacing; //distance the Instantiator will travel before instantiating a new prefab
	int generatedLevelLength; // this will track how many prefabs we have instantiated
	GameObject prefabToChoose;
	bool generating;


	// Use this for initialization
	void Start () {
		generatedLevelLength = 0;
		generating = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (generatedLevelLength < desiredLevelLength && generating == true) {
			for (int i = 0; i < desiredLevelLength; i++) {
				prefabToChoose = LevelPrefabs [Random.Range (0, LevelPrefabs.Count)];
				GameObject currentPrefab = GameObject.Instantiate (prefabToChoose, Instantiator.transform, Instantiator);
				currentPrefab.transform.position = new Vector2 (currentPrefab.transform.position.x + generateSpacing + (generateSpacing * (generatedLevelLength)), currentPrefab.transform.position.y);
				generatedLevelLength = generatedLevelLength + 1;
				print (i);
			}
		}
		if (generatedLevelLength == desiredLevelLength && generating == true) {
			GameObject currentPrefab = GameObject.Instantiate (EndLevelPrefab, Instantiator.transform, Instantiator);
			currentPrefab.transform.position = new Vector2 (currentPrefab.transform.position.x + generateSpacing + (generateSpacing * generatedLevelLength), currentPrefab.transform.position.y);
			generating = false;
		}
	}
}
