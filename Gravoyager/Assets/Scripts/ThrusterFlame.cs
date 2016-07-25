using UnityEngine;
using System.Collections;

public class ThrusterFlame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow))
			GetComponent<SpriteRenderer>().enabled = true;
		else
			GetComponent<SpriteRenderer>().enabled = false;
	}
}
