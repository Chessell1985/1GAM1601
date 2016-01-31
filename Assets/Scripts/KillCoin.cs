using UnityEngine;
using System.Collections;

public class KillCoin : MonoBehaviour {

	private SpriteRenderer s;

	void Awake () {

		s = GetComponent<SpriteRenderer> ();

	}

	void Update () {

		if (!s.isVisible && transform.position.x < 0) {

			DestroyObject (gameObject);

		}

	}

	void OnTriggerEnter2D (Collider2D other) {

		if (other.gameObject.CompareTag("Player")) {
			other.gameObject.GetComponent<PlayerControl> ().CollectCoin ();
			DestroyObject (gameObject);
		}

	}

}
