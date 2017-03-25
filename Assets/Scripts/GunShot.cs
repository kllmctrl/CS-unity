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

	EnemyAnimCtrl enemy;

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
			if(Physics.Raycast(ray, out hit, 100, 1<<9 | 1<<10)){ //100m 范围内：第九、第十层
				//Debug.Log ("####  hit name  ####" + hit.transform.name);

				//墙
				if(hit.transform.gameObject.layer == 10){
					//clone Henji
					GameObject henJi = (GameObject)Instantiate(bulletHenJi);
					henJi.transform.position = hit.point;
					henJi.transform.LookAt (hit.point + hit.normal);
				}

				//敌人
				if(hit.transform.gameObject.layer == 9){
					enemy = hit.transform.GetComponent<EnemyAnimCtrl> ();
					enemy.healthCtrl ();

				}

			}

			
		}

	}
}
