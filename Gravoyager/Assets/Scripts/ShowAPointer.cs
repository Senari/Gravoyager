using UnityEngine;
using System.Collections;


//This script is attached to some landing platforms.
//Script's idea is to show a pointer to the next points of interest, when Player landed on some platforms

public class ShowAPointer : MonoBehaviour 
{
	public GameObject pointerPrefab;//Prafab with Arrow or another pointer
	private bool showPointer = false;

	// Use this for initialization
	void Start () 
	{
		if (pointerPrefab != null)//Works if anything is set as Pointer
		{
			//pointerPrefab.SetActive(false);//By default all pointers ar switched off
			showPointer = false;
			print ("Arrow off");
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (showPointer == true) 
		{
			pointerPrefab.SetActive (true);

		}
		else if (showPointer == false) 
		{
			pointerPrefab.SetActive (false);
			//print ("Arrow Inactive!");

		}
	}
	void OnCollisionEnter2D(Collision2D collider)//When Player lands the platform
	{
		if (collider.gameObject.GetComponent<PolygonCollider2D>().tag == "Player") //if Player lands this platform
		{
			Contact ();
		}
	}
	void Contact()
	{
		print ("Contact!");
		showPointer = true;//Pointer is shown until next platform
		print ("Arrow works");
	}

}
