using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollower : MonoBehaviour {
	public Transform player;
	void Update () 
	{
		transform.position = new Vector3 (player.position.x +1 , 0, -10) ; 
	}
}
