using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public bool gameOver;

	void Awake() {
		if (instance == null)
			instance = this;
	}

	public void StartGame() {
		gameOver = false;
		UiManager.instance.GameStart ();
		ScoreManager.instance.StartScore ();
		GameObject.Find ("PlatformSpanner").GetComponent<PlatformSpanner> ().StartSpawning ();
	}

	public void GameOver() {
		UiManager.instance.GameOver ();
		ScoreManager.instance.StopScore ();
		gameOver = true;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
