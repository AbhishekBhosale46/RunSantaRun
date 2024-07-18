using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {

	private scoremanager thescoremanager;
	public goscreen gameoverscreen;

	void Start ()
	{
		thescoremanager = FindObjectOfType<scoremanager> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Collector") 
		{
			thescoremanager.scoreincreasing = false;
			gameoverscreen.gameObject.SetActive (true);
			thescoremanager.scorecount = 0;
			thescoremanager.scoreincreasing = false;
				Time.timeScale = 0;
		}

	}
}

