﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallOut : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision){
        GameObject.Find("Master").GetComponent<GameMaster>().GameOver("またの挑戦待ってるよ");
    }
}
