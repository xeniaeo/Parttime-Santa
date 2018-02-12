using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class UIControl : MonoBehaviour {
	public GameObject startUI;
	public GameObject scoreUI;
	public GameObject endUI;
	public GameObject InstantiateGift;
	public static bool isPlaying = false;
	private SteamVR_TrackedObject trackObj;//控制器
	public float startTime;

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
		//startUI.SetActive (true);
		scoreUI.SetActive(false);
		endUI.SetActive (false);
		InstantiateGift.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		// Press the trigger and start playing
		if (controller.GetPressDown (SteamVR_Controller.ButtonMask.Touchpad) && !isPlaying){
			scoreCount.score = 0;
			scoreUI.SetActive(true);
			startUI.SetActive (false);
			endUI.SetActive (false);
			isPlaying = true;
			startTime = Time.time;
			InstantiateGift.SetActive (true);
		}
		// Time's up
		if (isPlaying && (Time.time - startTime) > 60) {
			endUI.SetActive (true);
			scoreUI.SetActive(false);
			InstantiateGift.SetActive (false);
			isPlaying = false;
		}
	}
}
