using UnityEngine;
using System.Collections;
//This script is for calculating and storing objects' speeds
public class SpeedsOfObjects : MonoBehaviour
{
    private Vector2 oldPosition;//Old coordinates of object
    public float objectSpeed;

    void Start ()
    {       
        oldPosition = this.transform.position;
    }
	
	void FixedUpdate ()
    {        
        float distancePerTime = Vector2.Distance(oldPosition, this.transform.position);
        objectSpeed = distancePerTime;
        oldPosition = this.transform.position;
    }
}