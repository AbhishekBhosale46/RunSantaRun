using UnityEngine;
using System.Collections;

public class mainmenu : MonoBehaviour {

	public string level;

	public void Playgame ()
	{
		Application.LoadLevel(level);
	}

	public void Quit ()
	{
		Application.Quit ();
	}
}
