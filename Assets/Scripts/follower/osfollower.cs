using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class osfollower : MonoBehaviour {
	public Transform player;
	void Update () 
	{
		transform.position = new Vector3 (player.position.x +11, -3.65f, -3); 
	}
}
