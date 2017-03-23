using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHenJiCtrl : MonoBehaviour {
	float birthTime = 0;
	public float keepTime = 5;

	// Use this for initialization
	void Start () {
		birthTime = Time.time;	
	}
	
	// Update is called once per frame
	void Update () {
		if((Time.time - birthTime) > keepTime){
			Destroy (gameObject);
		}
	}
}
