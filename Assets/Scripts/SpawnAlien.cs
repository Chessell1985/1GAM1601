using UnityEngine;
using System.Collections;

public class SpawnAlien : MonoBehaviour {

	public float spawnYMin = 5f;
	public float spawnYMax = 10f;
	public float spawnX = 100f;

	public GameObject alien;

	void Awake () {

		InvokeRepeating ("Spawn", 0, 5);

	}

	// Update is called once per frame
	void Update () {

	}

	void Spawn () {

		float vX = spawnX;
		float vY = Random.Range (spawnYMin, spawnYMax);

		Vector3 spawnPosition = new Vector3 (vX, vY, 0f);

		Instantiate (alien, spawnPosition, Quaternion.identity);

	}

}
