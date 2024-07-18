using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giftspwanerfollower : MonoBehaviour {
	public Transform player;
	void Update () 
	{
		transform.position = new Vector3 (player.position.x +9.87f, -3.5f, -3); 
	}
}
