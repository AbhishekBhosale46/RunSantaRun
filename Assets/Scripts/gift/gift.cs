using System.Collections.Generic;
using UnityEngine;

public class gift : MonoBehaviour {

	public int CoinsToAdd;


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<PlayerMovement> () == null)
			return;

		giftmanager.AddCoins (CoinsToAdd);
		gameObject.SetActive (false);
	}
}
