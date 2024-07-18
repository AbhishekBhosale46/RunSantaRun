using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	private scoremanager thescoremanager;

	public float speed = -6f;
	private Rigidbody2D myRB;

	// Use this for initialization
	void Start () {
		thescoremanager = FindObjectOfType<scoremanager> ();
		myRB = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		myRB.velocity = new Vector2 (speed, 0);
		if (thescoremanager.scorecount >= 10) {
			speed = -4.7f;
		}
	}
}
