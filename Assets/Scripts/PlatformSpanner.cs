using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpanner : MonoBehaviour {

	Vector3 lastPos;
	float size;
	public GameObject platform;
	public GameObject collect;
	public bool gameOver;

	// Use this for initialization
	void Start () {
		lastPos = platform.transform.position;
		size = platform.transform.localScale.x;

	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.gameOver==true) {
			CancelInvoke ("SpawnPlatforms");
		}
		
	}
	void SpawnPlatforms() {
		
		if (Random.Range (0, 2) == 0) {
			SpawnX ();
		} else {
			SpawnZ ();
		}	
	}
	void SpawnX(){
		Vector3 pos = lastPos;
		pos.x += size;
		lastPos = pos;
		Instantiate (platform, pos,Quaternion.identity);
		if (Random.Range (0, 10) < 3) {
			pos.y += 1.5f;
			Instantiate (collect, pos,Quaternion.Euler(45f,45f,45f));
			pos.y -= 1.5f;
		}
	
	}

	public void StartSpawning() {
		InvokeRepeating ("SpawnPlatforms", 0.5f, 0.2f);
	}

	void SpawnZ() {
		Vector3 pos = lastPos;
		pos.z += size;
		lastPos = pos;
		Instantiate (platform, pos,Quaternion.identity);

		if (Random.Range (0, 10) < 3) {
			pos.y += 1.5f;
			Instantiate (collect, pos,Quaternion.Euler(45f,45f,45f));
			pos.y -= 1.5f;
		}
	}
}
