﻿using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () { 

    }


    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Gates")
        {

            Application.LoadLevel(3);

        }


    }
}