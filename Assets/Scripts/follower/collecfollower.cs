﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collecfollower : MonoBehaviour {
	public Transform player;
	void Update () 
	{
		transform.position = new Vector3 (player.position.x -10 , -1, 0) ; 
	}
}
