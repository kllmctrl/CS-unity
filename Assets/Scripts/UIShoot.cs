//***************************************************************
///   @ Brief:   显示阻击焦点
///   @ Author:  kc
///   @ Date:    2017-3-19
//***************************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIShoot : MonoBehaviour {
	public Texture2D shotCenter;
	Rect rectShotCenter;

	// Use this for initialization
	void Start () {
		float centerSize = Screen.height * 0.05f;
		rectShotCenter = new Rect ((Screen.width - centerSize) * 0.5f, (Screen.height - centerSize) * 0.5f, centerSize, centerSize);
	}
	
	// Update is called once per frames
	void Update () {
		
	}

	void OnGUI(){
		GUI.DrawTexture (rectShotCenter, shotCenter);
	}
}
