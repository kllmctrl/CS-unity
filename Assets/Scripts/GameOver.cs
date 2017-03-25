using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour {
	public GUIStyle styleCenter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalCS.gameOver) {
			Time.timeScale = 0;
			Cursor.visible = true;
		} else {
			Time.timeScale = 1;
		}
	}

	//弹窗
	void OnGUI(){
		if(GlobalCS.gameOver){
			GUI.Label (new Rect(Screen.width * 0.5f - 120, Screen.height * 0.5f - 64, 256, 128), "Game Over", styleCenter);
			if (GUI.Button (new Rect (Screen.width * 0.5f - 90, Screen.height * 0.5f + 32, 64, 32), "Retry")) {
				GlobalCS.reset ();
				SceneManager.LoadScene("CS_scene");

			}
			if (GUI.Button (new Rect (Screen.width * 0.5f + 32, Screen.height * 0.5f + 32, 64, 32), "Exit")) {
				Application.Quit ();
			}
		}
	}


}
