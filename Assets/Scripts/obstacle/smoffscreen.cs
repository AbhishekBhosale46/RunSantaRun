using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoffscreen : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Zombie") {
			gameObject.SetActive (false);
		}
	}
}
