using UnityEngine;
using System.Collections;


//This script is attached to some landing platforms.
//Script's idea is to show a pointer to the next points of interest, when Player landed on some platforms

public class ShowAPointer : MonoBehaviour 
{
	public GameObject pointerPrefab;//Prafab with Arrow or another pointer

	// Use this for initialization
	void Start () 
	{
		if (pointerPrefab != null)//Works if anything is set as Pointer
		{
			//pointerPrefab.SetActive(false);//By default all pointers ar switched off
			print ("Arrow off");
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void onCollisionStay2D(Collision2D collider)//When Player lands the platform
	{
		if (collider.gameObject.tag == "Player") //if Player lands this platform
		{
			pointerPrefab.SetActive(true);//Pointer is shown until next platform
			print ("Arrow works");
		}
	}

}
