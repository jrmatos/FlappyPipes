using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesController : MonoBehaviour {

	[Header("Velocity")]
	public float pipesVelocity;

	// rigid body
	private Rigidbody2D rigidBody2d;

	// pipes Y limits
	float maxY = 5f;
	float minY = -6.3f;

	// Use this for initialization
	void Start () {
		rigidBody2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {		
		CheckPipesPosition ();
		MovePipes ();
	}

	void CheckPipesPosition() {
		if (transform.position.y < minY) {			
			rigidBody2d.constraints = RigidbodyConstraints2D.FreezePositionY;
			Debug.Log ("Game Over!!!");
		}
	}

	void MovePipes() {
		if (Input.GetKeyDown (KeyCode.Space) && transform.position.y < maxY) {
			FlappyPipes ();
		}
	}

	void FlappyPipes() {
		rigidBody2d.velocity = Vector2.up * pipesVelocity;
	}

}
