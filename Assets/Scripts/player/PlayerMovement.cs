﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float jumpForce = 5f;
	public float forwardForce = 2f;

	private Rigidbody2D myRB;
	private bool canJump;

	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody2D> ();
	}

	// Jump Funktion
	public void Jump()
	{
		// Darf Spieler überhaupt springen?
		if (canJump) 
		{
			canJump = false;

			// Ist die Position des Spielers aktuell in der Mitte?
			if (transform.position.x < 0) 
			{
				// Spieler befindet sich aktuell nicht in der Mitte
				forwardForce = 0.7f;
			} else 
			{
				// Spieler ist in der Mitte
				forwardForce = 0.7f;
			}

			myRB.velocity = new Vector2 (forwardForce, jumpForce);
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		canJump = true;
	}
}
