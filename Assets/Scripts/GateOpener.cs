﻿using UnityEngine;
using System.Collections;

public class GateOpener : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("f")){
			gameObject.SetActive(false);
		}
	}
}