using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTarger : MonoBehaviour {

	UnityEngine.AI.NavMeshAgent agent;
	public Transform player;
	Animator anim;

	// Use this for initialization
	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		agent.enabled = false;
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(anim.GetInteger("state") == 1){
			agent.enabled = true;
			agent.SetDestination (player.position);
		}
		if(anim.GetInteger("state") == 3){
			agent.enabled = false;
		}


	}
}
