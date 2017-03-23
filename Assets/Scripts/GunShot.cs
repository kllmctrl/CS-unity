//***************************************************************
///   @ Brief:   射击逻辑
///   @ Author:  kc
///   @ Date:    2017-3-19
//***************************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour {

	AudioSource ShootSound;
	public GameObject bulletHenJi;

	// Use this for initialization
	void Start () {
		ShootSound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			ShootSound.Play ();

			Ray ray = Camera.main.ScreenPointToRay (new Vector2(Screen.width * 0.5f, Screen.height * 0.5f));
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit)){
				//Debug.Log ("####  hit name  ####" + hit.transform.name);
				//clone Henji
				GameObject henJi = (GameObject)Instantiate(bulletHenJi);
				henJi.transform.position = hit.point;
				henJi.transform.LookAt (hit.point + hit.normal);
			}

			
		}

	}
}
