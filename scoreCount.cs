using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCount : MonoBehaviour {
	public static int score = 0;
	public Text scoreText;
	public GameObject scoreCanvas;

	// Use this for initialization
	void Start () {
		scoreCanvas.SetActive(true);
		scoreText.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		// Add scores
		scoreText.GetComponent<Text> ().text = score.ToString ();
	}
}
