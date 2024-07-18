using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class goscreen : MonoBehaviour {

	public string level;

	public void restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
	}

	// Use this for initialization
	public void Mainmenu () {
		Application.LoadLevel(level);
		Time.timeScale = 1;
	}

	// Update is called once per frame
	void Update () {

	}
}
