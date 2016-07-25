
//This script should apply a known amount of the force to the object at very start of the game. This way object will receive a start speed and screw around the planet.
using UnityEngine;
using System.Collections;

public class ObjectOrbit : MonoBehaviour {
    public GameObject body;
    private Rigidbody2D rigidbody;
    public float appliedForce = 1;
    
	// Use this for initialization
	void Start () {
        print(appliedForce);
        float bodyMass = this.GetComponent<Rigidbody2D>().mass;
        rigidbody = this.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(transform.right * appliedForce);

        print("moving thing");
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
