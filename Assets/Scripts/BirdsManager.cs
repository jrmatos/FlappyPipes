using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdsManager : MonoBehaviour {

	public GameObject Bird;

	// Use this for initialization
	void Start () {		
		InvokeRepeating("GenerateBirds", 0f, 2.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GenerateBirds() {
		GameObject bird = (GameObject)Instantiate (Bird);
		bird.transform.position = new Vector2 (10,Random.Range (4f, -2f));
	}

}
