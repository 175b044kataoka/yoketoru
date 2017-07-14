using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCheck : MonoBehaviour {
	//使わない場合、StartとUpdateは消してよい

	//ぶつかった時の処理
	void OnTriggerEnter(Collider col){
		Destroy (gameObject);
	}

	//マウスが重なった時の処理
	// Use this for initialization
	/*void OnMouseEnter()
	{
		Destroy(gameObject);
		Debug.Log ("hit");
		//gameObject.SetActive (false);
		//Time.timeScale=0f;
	}*/
}
