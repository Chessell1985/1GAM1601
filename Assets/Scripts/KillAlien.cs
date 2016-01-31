using UnityEngine;
using System.Collections;

public class KillAlien : MonoBehaviour {

	private SpriteRenderer s;

	void Awake () {

		s = GetComponent<SpriteRenderer> ();

	}

	void Update () {

		if (!s.isVisible && transform.position.x < 0) {

			DestroyObject (gameObject);

		}

	}
}
