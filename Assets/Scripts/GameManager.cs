using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public static string NextScene = "";

	// Use this for initialization
	void Start () {
		GameParams.SetScore (0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.O)) {
			NextScene = "Game Over";
		} else if (Input.GetKeyDown (KeyCode.C)) {
			NextScene = "Clear";
		}
		//Aキー
		else if (Input.GetKey (KeyCode.A)) {
			GameParams.AddScore (1000);
		}

		if (NextScene.Length > 0) {
			SceneManager.LoadSceneAsync (NextScene,LoadSceneMode.Additive);
			NextScene = "";
			enabled = false;
		}
	}
}
