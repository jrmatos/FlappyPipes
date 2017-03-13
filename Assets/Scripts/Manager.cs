using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

	public static bool gameOver;

	public static int score;

	CanvasGroup canvasGroup;
	CanvasGroup shareScreenshotButton;

	// Use this for initialization
	void Start () {
		gameOver = false;
		canvasGroup = GameObject.Find("PlayButton").GetComponent<CanvasGroup>();
		shareScreenshotButton = GameObject.Find ("ShareScreenshotButton").GetComponent<CanvasGroup> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver) {
			Time.timeScale = 0;
			canvasGroup.alpha = 1f;
			canvasGroup.interactable = true;
			canvasGroup.blocksRaycasts = true;

			shareScreenshotButton.alpha = 1f;
			shareScreenshotButton.interactable = true;
			shareScreenshotButton.blocksRaycasts = true;
		}
	}

	public static void addScore() {
		score++;
	}
}
