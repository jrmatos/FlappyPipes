using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

	public static bool gameOver;

	public static int score;

	// Use this for initialization
	void Start () {
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver) {
			Time.timeScale = 0;
		}
	}

	public static void addScore() {
		score++;
	}
}
