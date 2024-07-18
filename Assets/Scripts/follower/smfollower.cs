using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smfollower : MonoBehaviour {
	public Transform player;
	void Update () 
	{
		transform.position = new Vector3 (player.position.x +13, -3, -1); 
	}
}
