using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class TargetFinder : NetworkBehaviour {

	public GameObject[] players;
	int time;

	// Use this for initialization
	void Start () {
		players = GameObject.FindGameObjectsWithTag("Player");
		Target ();
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (time == 300) {
			Target ();
			time = 0;
		}
		time++;
	}

	void Target () {
		int index = Random.Range (0, players.Length);
		if (players[index] == isLocalPlayer) {
			Target ();
		} 
		else {
			
			Color col = players[index].GetComponent<PlayerColor> ().color;
			GetComponent<Image> ().color = col;
		}
	}
}
