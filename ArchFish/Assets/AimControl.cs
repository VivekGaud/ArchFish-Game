﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
            transform.position = new Vector3
                (
                Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                Camera.main.ScreenToWorldPoint(Input.mousePosition).y,
                transform.position.z
                );

    }
}
