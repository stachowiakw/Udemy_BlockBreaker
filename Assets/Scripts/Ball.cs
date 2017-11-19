﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Paddle PaddleInstance;
    private bool HasStarted = false;
    private Vector3 paddleToBallVector;

    // Use this for initialization
    void Start () {
        paddleToBallVector = this.transform.position - PaddleInstance.transform.position;
        print(paddleToBallVector);
	}
	
	// Update is called once per frame
	void Update () {
        if (HasStarted == false) { this.transform.position = PaddleInstance.transform.position + paddleToBallVector; }

        if(Input.GetMouseButtonDown(0))
        {
            print("MouseClicked, lunching ball");
            if (HasStarted == false) { GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f); }
            HasStarted = true;
        }
	}
}