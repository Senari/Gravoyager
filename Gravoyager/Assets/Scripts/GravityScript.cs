﻿using UnityEngine;
using System.Collections;

public class GravityScript : MonoBehaviour
{
    private GameObject[] body;

    // Use this for initialization
 
        // Update is called once per frame
        void FixedUpdate()//Fixed = experimental
        {
            body = GameObject.FindGameObjectsWithTag("Massed");
            for (int i = 0; i < body.Length; i++)
            {
            // exclude yourself
            if (body[i] != gameObject)
            {

                Vector2 bodyPos = body[i].transform.position;//Creating an objects to work with Player and Planet
                Vector2 playerPos = this.transform.position; //"This" because script is applied to player


                float distance = Vector2.Distance(bodyPos, playerPos);//Function to find the distance. Vector2 because of 2D dimension.
                //print("Distance to the center ("+i+"): " + distance);


                //float planetRadius = planet.transform.localScale;
                //float altitude = distance - planetRadius;


                float playerMass = this.GetComponent<Rigidbody2D>().mass;//Taking mass from Rigidbody
                float bodyMass = body[i].GetComponent<Rigidbody2D>().mass;


                float weight = (bodyMass * playerMass) / (distance * distance);
                //print("Pulling force, kN: (" + i + ")" + weight);
                Vector2 gravity = body[i].transform.position - this.transform.position;
                GetComponent<Rigidbody2D>().AddForce(gravity.normalized * weight)/*(1.0f - dist / maxGravDist) * maxGravity)*/;
            }
        }
    }
}
