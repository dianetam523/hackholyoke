﻿using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		var target = GameObject.FindGameObjectWithTag ("CrossHair").transform.position;
		if (Physics.Raycast (target, transform.forward)) {
			print ("Hit something!");
		}
	}
}
