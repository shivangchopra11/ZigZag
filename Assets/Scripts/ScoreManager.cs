using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
	public int score;
	public int highScore;
	public static ScoreManager instance;
	void Awake() {
		if (instance == null) {
			instance = this;
		}
	}

	void IncrementScore() {
		score++;
		UiManager.instance.gameScore.text = "Score : " + score.ToString ();
	}

	public void DiamandScore() {
		score+=10;
		UiManager.instance.gameScore.text = "Score : " + score.ToString ();
	}



	// Use this for initialization
	void Start () {
		score = 0;
		PlayerPrefs.SetInt ("score", score);
	}

	public void StartScore() {
		InvokeRepeating ("IncrementScore", 0.1f, 0.5f);
	}

	public void StopScore() {
		CancelInvoke ("IncrementScore");
		PlayerPrefs.SetInt ("score", score);
		if(PlayerPrefs.HasKey("highScore")) {
			if(score > PlayerPrefs.GetInt("highScore"))
				PlayerPrefs.SetInt("highScore",score);
		}
		else {
				PlayerPrefs.SetInt("highScore",score);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
