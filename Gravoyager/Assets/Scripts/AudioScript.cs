using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {


	public AudioSource sound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
			sound.Play();


	}
}
