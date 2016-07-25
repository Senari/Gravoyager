using UnityEngine;
using System.Collections;



public class ThrusterFlame : MonoBehaviour {
	public GameObject forwardFlame;
	public GameObject reverseFlame;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow))
			forwardFlame.GetComponent<SpriteRenderer>().enabled = true;
		else	
		forwardFlame.GetComponent<SpriteRenderer>().enabled = false;

		if (Input.GetKey (KeyCode.DownArrow))
			reverseFlame.GetComponent<SpriteRenderer>().enabled = true;
		else
			
			reverseFlame.GetComponent<SpriteRenderer>().enabled = false;


	}
}
