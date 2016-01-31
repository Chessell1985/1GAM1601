using UnityEngine;
using System.Collections;

public class MoveFlyingEnemy : MonoBehaviour {

	public float moveSpeed = 1f;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Awake () {

		rb2d = GetComponent<Rigidbody2D> ();

		rb2d.velocity = new Vector3 (moveSpeed, 0, 0);

		Vector3 theScale = transform.localScale;
		if (moveSpeed < 0) {
			theScale.x *= -1;
		}

		transform.localScale = theScale;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
