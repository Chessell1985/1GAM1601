using UnityEngine;
using System.Collections;

public class MoveBackground : MonoBehaviour {

	public float speed = 0.5f;

	private Renderer r;

	void Awake () {

		r = GetComponent<Renderer> ();

	}
	
	// Update is called once per frame
	void Update () {

		Vector2 offset = new Vector2 (Time.time * speed, 0);

		r.material.mainTextureOffset = offset;
	
	}
}
