using UnityEngine;
using System.Collections;

public class FuelStations : MonoBehaviour 
{
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            print("Fueling");
        }
    }
}