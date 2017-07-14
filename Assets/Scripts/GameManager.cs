using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	private static string _nextScene = "";
	public static string NextScene {
		get { return _nextScene; }
		set {
			if ((_nextScene != "Clear")
			    || (value == "")) {
				_nextScene = value;
			}
		}
	}

	// Use this for initialization
	void Start () {
		GameParams.SetScore (0);
	}
	
	// Update is called once per frame
	void Update () {
		// oキー
		if (Input.GetKeyDown (KeyCode.O)) {
			NextScene = "Game Over";
		// cキー
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
