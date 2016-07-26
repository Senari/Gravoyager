using UnityEngine;
using System.Collections;

public class ThrusterFlame : MonoBehaviour 
{	
	public GameObject forwardFlame;
	public GameObject reverseFlame;
    //private bool ifEnoughFuel = PlayerScript.FuelConsumption(); //I want to have an access to that method in PlayerScript class

    public float fuel;

	void Start () 
	{
		
	}
		
	void FixedUpdate() 
	{

        fuel = PlayerScript.S.ReturnFuel();

        
            //For main thruster
            if (Input.GetKey(KeyCode.UpArrow) && fuel >= 0) //And if THAT method in another class shows there is some fuel in tanks
                forwardFlame.GetComponent<SpriteRenderer>().enabled = true;
            else
                forwardFlame.GetComponent<SpriteRenderer>().enabled = false;

            //And for reverse thruster
            if (Input.GetKey(KeyCode.DownArrow) && fuel >= 0)
                reverseFlame.GetComponent<SpriteRenderer>().enabled = true;
            else
                reverseFlame.GetComponent<SpriteRenderer>().enabled = false;
        
	}
}
