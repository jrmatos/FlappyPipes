using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {
	
	[Header("velocity")]
	public float birdVelocity;

	Vector3 pos;

	Vector2 screenBorderLeft;

	// Use this for initialization
	void Start () {
		pos = transform.position;

		// get screen border
		screenBorderLeft = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));
	}
	
	// Update is called once per frame
	void Update () {
		move ();
		DestroyOutOfWorld ();

		if (transform.position.x < -10) {
			Destroy (gameObject);
		}

	}

	void move() {
		pos.x = pos.x - (birdVelocity * Time.deltaTime);
		transform.position = pos;
	}

	void DestroyOutOfWorld(){		
		if (transform.position.x < screenBorderLeft.x) {			
			Destroy (gameObject);
		}
	}


}
