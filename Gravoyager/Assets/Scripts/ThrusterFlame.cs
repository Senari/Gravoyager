using UnityEngine;
using System.Collections;

public class ThrusterFlame : MonoBehaviour 
{	
	public GameObject forwardFlame;
	public GameObject reverseFlame;
	public float fuel;

	void FixedUpdate ()
	{
		fuel = PlayerScript.S.ReturnFuel();

		if (GameObject.Find("Player").GetComponent<PlayerScript>().Alive) // Disables thrusters if the player is dead
		{
			//For main thruster
			if (Input.GetKey (KeyCode.UpArrow) && fuel >= 0)
				forwardFlame.GetComponent<SpriteRenderer> ().enabled = true;
			else
				forwardFlame.GetComponent<SpriteRenderer> ().enabled = false;

			//And for reverse thruster
			if (Input.GetKey (KeyCode.DownArrow) && fuel >= 0)
				reverseFlame.GetComponent<SpriteRenderer> ().enabled = true;
			else
				reverseFlame.GetComponent<SpriteRenderer> ().enabled = false;
		}
		//These lines prevent the thrusters from staying on after player death
		else
			forwardFlame.GetComponent<SpriteRenderer> ().enabled = false;
			reverseFlame.GetComponent<SpriteRenderer> ().enabled = false;
	}
}