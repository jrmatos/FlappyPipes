using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour {

	private ScoreManager scoreManager;

	// Use this for initialization
	void Start () {
		scoreManager = GameObject.FindObjectOfType<ScoreManager> ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.CompareTag ("bird")) {
			scoreManager.AddScore (1);
		}
	}
}