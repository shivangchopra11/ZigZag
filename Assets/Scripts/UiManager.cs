﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {
	public static UiManager instance;
	public GameObject zigZagPanel;
	public GameObject gameOverPanel;
	public GameObject tapText;
	public Text gameScore;
	public Text score;
	public Text highScore1;
	public Text highScore2;
	// Use this for initialization

	void Awake() {
		if (instance == null) {
			instance = this;
		}
	}

	void Start () {
		highScore1.text = "High Score : " + PlayerPrefs.GetInt ("highScore").ToString();
	}

	public void GameStart() {
		gameScore.text = "Score : 0";
		tapText.SetActive (false);
		zigZagPanel.GetComponent<Animator> ().Play ("PanelUp");
	}

	public void GameOver() {
		score.text = PlayerPrefs.GetInt ("score").ToString();
		highScore2.text = PlayerPrefs.GetInt ("highScore").ToString();
		gameOverPanel.SetActive (true);
		gameScore.text = "";

	
	}

	public void Reset() {
		SceneManager.LoadScene (0);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
