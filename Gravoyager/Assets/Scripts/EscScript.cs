﻿using UnityEngine;
using System.Collections;

public class EscScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            else {
                Time.timeScale = 0;
            }
        }
    }
    void OnGUI()
    {
        if (Time.timeScale == 0)
        {
            //Display your gui.        
        }
    }
}
