using UnityEngine;
using System.Collections;


//This script is attached to some landing platforms.
//Script's idea is to show a pointer to the next points of interest, when Player landed on some platforms

public class ShowAPointer : MonoBehaviour 
{
	public GameObject pointerPrefab;//Prefab with Arrow or another Pointer
	private bool showPointer = false;

	void Start () 
	{
		if (pointerPrefab != null)//Works if anything is set as Pointer
		{
			//pointerPrefab.SetActive(false);//By default all pointers ar switched off
			showPointer = false;
		}
	}
	
	void FixedUpdate () 
	{
		if (showPointer == true) 
		{
			pointerPrefab.SetActive (true);
		}
		else if (showPointer == false) 
		{
			pointerPrefab.SetActive (false);
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
		showPointer = true;//Pointer is shown (next step - is to show only one pointer at same time. Maybe via Pointer.script)
	}

}
