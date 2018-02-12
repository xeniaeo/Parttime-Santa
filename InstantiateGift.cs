using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGift : MonoBehaviour {
	public GameObject[] gifts;
	private GameObject giftClone;
	private float InstantiationTimer = 1f;

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {		

		InstantiationTimer -= Time.deltaTime;
		if (InstantiationTimer <= 0)
		{
			giftClone = Instantiate (gifts[Random.Range(0, gifts.Length)], transform.position + new Vector3(Random.Range(-1, 1), 0, Random.Range(-1, 1)), transform.rotation) as GameObject; //Random.Range(-2, 2)
			InstantiationTimer = 1f;
		}
	}
}
