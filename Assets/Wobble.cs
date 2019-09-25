using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Wobble : MonoBehaviour {

	public float m_maxTilt = 20f;
	public float m_currTilt = 0f;
	public float m_smooth = 5f;

	float sigmoid(float x, float x_offset) {
		return (float)(1 / (1 + Math.Exp((double)(-x + x_offset))));
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {		
		transform.Rotate(0, m_currTilt, 0, Space.World);
	}
}