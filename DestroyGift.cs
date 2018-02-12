using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGift : MonoBehaviour {
	public GameObject particle;
	private GameObject particleClone;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision others){
		if (others.gameObject.tag == "gift"){
			Destroy(others.gameObject, 2f);
			//particleClone = Instantiate (particle, others.transform.position, others.transform.rotation) as GameObject;
			//Destroy (particleClone, 0.5f);
		}
	}
}
