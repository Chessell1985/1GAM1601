using UnityEngine;
using System.Collections;

public class SpawnCoins : MonoBehaviour {

	public int coinsLength = 8;

	public float spawnYMin = 5f;
	public float spawnYMax = 10f;
	public float spawnX = 100f;
	public float spawnSpacingX = 32f;

	public GameObject coin;

	void Awake () {

		InvokeRepeating ("SpawnCoin", 0, 3);

	}
	
	// Update is called once per frame
	void Update () {

	}

	void SpawnCoin () {

		float startY = Random.Range (spawnYMin, spawnYMax);
		float endY = Random.Range (spawnYMin, spawnYMax);

		float vX, vY;

		Vector3 spawnPosition;

		for (float i = 0; i < coinsLength; i += 1f) {

			//Debug.Log ("Spawning Coin");

			vX = spawnX + (i * spawnSpacingX);
			vY = startY + ((endY - startY) * (i / coinsLength));

			//Debug.Log ("vX : " + vX.ToString () + ", vY : " + vY.ToString ());

			spawnPosition = new Vector3 (vX, vY, 0f);

			Instantiate (coin, spawnPosition, Quaternion.identity);

		}

	}
}
