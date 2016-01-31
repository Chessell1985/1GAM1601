using UnityEngine;
using System.Collections;

public class MoveAlien : MonoBehaviour {

	public float yOffsetMax = 2f;
	public float yOffsetMin = -2f;
	public float ySmooth = 0.1f;
	public float ySpeed = 4f;

	private float yMax;
	private float yMin;
	private float yDestination;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Awake () {

		yMax = transform.position.y + yOffsetMax;
		yMin = transform.position.y + yOffsetMin;

		yDestination = yMin;

		rb2d = GetComponent<Rigidbody2D> ();

		rb2d.velocity = new Vector3 (rb2d.velocity.x, ySpeed, 0f);

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (transform.position.y >= yMax) {

			rb2d.velocity = new Vector3 (rb2d.velocity.x, -ySpeed, 0f);

		} else if(transform.position.y <= yMin) {

			rb2d.velocity = new Vector3 (rb2d.velocity.x, ySpeed, 0f);

		}

	}
}
