using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTarger : MonoBehaviour {

	UnityEngine.AI.NavMeshAgent agent;
	Transform player;
	Animator anim;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("player").transform;
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		agent.enabled = false;
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		//跑状态寻路
		if(anim.GetInteger("state") == 1){
			agent.enabled = true;
			agent.SetDestination (player.position);
		}

		//死亡后，停止寻路
		if(anim.GetInteger("state") == 3){
			agent.enabled = false;
		}

		if(Vector3.SqrMagnitude(transform.position - player.transform.position) < 2.0f){
			GlobalCS.gameOver = true;
			gameObject.SetActive (false);
			GetComponent<FindTarger> ().enabled = false;
		}

	}
}
