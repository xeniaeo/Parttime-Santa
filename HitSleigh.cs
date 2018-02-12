using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSleigh : MonoBehaviour {
	public GameObject particle;
	private GameObject particleClone;
	public AudioSource audio;

	// Use this for initialization
	void Start () {
		AudioSource audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider others){
		if (others.gameObject.tag == "gift" && UIControl.isPlaying){
			Destroy(others.gameObject);
			scoreCount.score += 50;
			// particle effect
			particleClone = Instantiate (particle, transform.position, transform.rotation) as GameObject;
			Destroy (particleClone, 3f);

			audio.Play();
		}
	}
}
