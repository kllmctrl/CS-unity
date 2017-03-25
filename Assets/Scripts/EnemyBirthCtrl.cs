using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBirthCtrl : MonoBehaviour {
	public GameObject[] objs;
	float birthTime;
	float birthInterval = 5.0f;
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		birthTime = birthInterval;
	}
	
	// Update is called once per frame
	void Update () {
		birthTime -= Time.deltaTime;
		if(birthTime < 0){
			//copy enemy
			Instantiate(enemy, objs[Random.Range(0, objs.Length-1)].transform.position, Quaternion.identity);

			birthTime = birthInterval;
		}
		
	}
}
