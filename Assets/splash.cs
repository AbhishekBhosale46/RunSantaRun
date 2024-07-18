using UnityEngine;
using System.Collections;

public class splash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("Countdown");
	}

	private IEnumerator Countdown ()
	{
		yield return new WaitForSeconds (0.9f);
		Application.LoadLevel (1);
	}
}
