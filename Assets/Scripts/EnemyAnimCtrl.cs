using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimCtrl : MonoBehaviour {

	Animator anim;
	int health = 100;
	float birthTime = 0.0f;
	float deadTime;
	float deadKeepTime = 5.0f;

	Transform player;
	float disAttach = 2.0f;


	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("player").transform;
		anim = GetComponent<Animator> ();
		anim.SetInteger ("state", 0);
		birthTime = Time.time;
		deadTime = deadKeepTime;
	}


	// Update is called once per frame
	void Update () {
		//死亡
		if (health <= 0) {
			anim.SetInteger ("state", 3);
			deadTime -= Time.deltaTime;
			if(deadTime < 0){
				Destroy (gameObject);
			}
		} else {
			if (Time.time - birthTime > 2) {
				if (Vector3.SqrMagnitude (transform.position - player.position) > disAttach * disAttach) {
					//攻击
					anim.SetInteger ("state", 1);
				} else {
					//跑
					anim.SetInteger ("state", 2);
				}
			} else {
				anim.SetInteger ("state", 0);
			}

		}
	}


	//掉血
	public void healthCtrl(){
		health -= 30;
		Debug.Log ("####  health  ####" + health);
	}

}
