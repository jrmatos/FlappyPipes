using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesController : MonoBehaviour {

	[Header("Velocity")]
	public float pipesVelocity;

	// rigid body
	private Rigidbody2D rigidBody2d;

	// Use this for initialization
	void Start () {
		rigidBody2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		MovePipes ();
	}

	void MovePipes() {
		if (Input.GetKeyDown (KeyCode.Space)) {
			FlappyPipes ();
		}
	}

	void FlappyPipes() {
		rigidBody2d.velocity = Vector2.up * pipesVelocity;
	}

}
