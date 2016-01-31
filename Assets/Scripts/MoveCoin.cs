using UnityEngine;
using System.Collections;

public class MoveCoin : MonoBehaviour {

	public float speed = 8f;

	private Rigidbody2D rb2d;

	void Awake () {

		rb2d = GetComponent<Rigidbody2D> ();

		rb2d.velocity = new Vector3 ((speed * -1), 0f, 0f);

	}

	// Update is called once per frame
	void Update () {

	}
}
