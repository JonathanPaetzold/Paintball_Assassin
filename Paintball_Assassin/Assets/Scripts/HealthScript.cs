using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {


	public Text health;
	private int currentHealth;
	private int maxHealth;

	// Use this for initialization
	void Start () {
		currentHealth = 100;
		maxHealth = 100;
		health.text = "";
		
	}
	
	// Update is called once per frame
	void Update () {
		updateText ();
	}


	void updateText () {
		health.text = "Health:" + currentHealth.ToString () + "/" + maxHealth.ToString ();

	}
}
