﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetAxis : MonoBehaviour {
	
	public float speed;

	void Update() {
		this.transform.Rotate(new Vector3(0, this.speed * Time.deltaTime, 0));
	}
}
