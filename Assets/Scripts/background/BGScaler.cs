﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Höhe berechen
		float height = Camera.main.orthographicSize * 2f;
		// Breite berechnen
		float width = height * Screen.width / Screen.height;

		if (gameObject.name == "Background") {
			// GameObject (Background) skalieren
			transform.localScale = new Vector3 (16, height, 0);
		} else
			transform.localScale = new Vector3 (16, 2, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
