using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Hand : MonoBehaviour {
	private SteamVR_TrackedObject trackObj;//控制器
	private GameObject collidingObject; 
	private GameObject objectInHand; 

	//取得控制器的哪個按鈕被壓下、放開、觸碰
	private SteamVR_Controller.Device controller
	{
		get
		{
			return SteamVR_Controller.Input((int)trackObj.index);
		}
	}

	// Use this for initialization
	void Start () {
		trackObj = GetComponent<SteamVR_TrackedObject>();//取得控制器腳本物件
	}
	
	// Update is called once per frame
	void Update () {

	}
		
	void OnCollisionStay(Collision others){
		collidingObject = others.gameObject;
		if (controller.GetPress (SteamVR_Controller.ButtonMask.Trigger)) {
			objectInHand = collidingObject;
			collidingObject = null;

			objectInHand.transform.position = this.transform.position;
			objectInHand.transform.rotation = this.transform.rotation;

		} 
		if (controller.GetPressUp (SteamVR_Controller.ButtonMask.Trigger)) {
			objectInHand.GetComponent<Rigidbody> ().AddForce (transform.forward*170f, ForceMode.Impulse);
		}
	}

	private FixedJoint AddFixedJoint()
	{
		FixedJoint fx = gameObject.AddComponent<FixedJoint>();
		fx.breakForce = 20000;
		fx.breakTorque = 20000;
		return fx;
	}
}
