using UnityEngine;
using System.Collections;

public class AsteroidScript : MonoBehaviour {


    public GameObject asteroidPrefab;
    public float fieldRadius;
    public float size;
    public float movementSpeed;
    public float rotationSpeed;



    // Use this for initialization
    void Start () {
        for (int i = 0; i < 100; ++i)
        {
            GameObject newAsteroid = (GameObject)Instantiate(asteroidPrefab, Random.insideUnitSphere * fieldRadius, Random.rotation);
            float size = Random.Range(0.01f, 2);
            newAsteroid.transform.localScale = Vector3.one * size;
            // if the asteroid has a rigidbody...
            newAsteroid.GetComponent<Rigidbody>().velocity = Random.insideUnitSphere * movementSpeed;
             newAsteroid.GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * rotationSpeed;
        }
    }
	
	// Update is called once per frame
	void Update () {
     
    }
}
