using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour {

	public Text scoretext;
	public Text highscoretext;
	public Text gifttext;
	public float scorecount;
	public float highscorecount;
	public float giftcount;
	public float pointspersec;
	public bool scoreincreasing;

	void Start () {
		if(PlayerPrefs.HasKey("HighScore"))
		{
			highscorecount = PlayerPrefs.GetFloat("HighScore");
		}
	}

	void Update () {

		if (scoreincreasing) 
		{
			scorecount += pointspersec * Time.deltaTime;
		}

		if (scorecount > highscorecount)
		{
			highscorecount = scorecount;
			PlayerPrefs.SetFloat ("HighScore", highscorecount);
		}

		scoretext.text = "Score : " + Mathf.Round(scorecount);
		highscoretext.text = "HighScore : " + Mathf.Round(highscorecount);
	}

}

