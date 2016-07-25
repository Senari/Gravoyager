using UnityEngine;
using System.Collections;

public class ThrusterFlame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow))
			SpriteRenderer.sprite = "FlameDualBlue";
		else
			SpriteRenderer.sprite = none;
	}
}
