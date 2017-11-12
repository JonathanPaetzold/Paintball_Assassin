using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour {

	public Text ammo;
	private int currentAmmo;
	private int reserveAmmo;

	// Use this for initialization
	void Start () {
		currentAmmo = 30;
		reserveAmmo = 120;
		ammo.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		updateText ();
		
	}


	void updateText () {
		ammo.text = "Ammo: " + currentAmmo.ToString () + "/" + reserveAmmo.ToString ();
	
	}

}