using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giftspwanerupfollower : MonoBehaviour {
	public Transform player;
	void Update () 
	{
		transform.position = new Vector3 (player.position.x +9.87f, -1.8f, -3); 
	}
}
