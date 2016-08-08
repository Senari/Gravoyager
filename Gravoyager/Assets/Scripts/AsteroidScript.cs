using UnityEngine;
using System.Collections;

public class AsteroidScript : MonoBehaviour {


    public GameObject asteroidPrefab;
    public float fieldRadius;
    public float size;
    public float movementSpeed;
    public float rotationSpeed;

	public GameObject SpawnPoint;

	int laskuri = 0;

	public int length = 340;
    public int amount = 500;
    public int startPoint = 170;


    // Use this for initialization
    void Start () {

	


        for (int i = 0; i < amount; i++)
        {
			if (laskuri >= length) {

				laskuri = 0;

			}


			GameObject newAsteroid = (GameObject)Instantiate(asteroidPrefab, new Vector3(laskuri + (SpawnPoint.transform.position.x - startPoint), SpawnPoint.transform.position.y, 0), Quaternion.identity);
            float size = Random.Range(0.01f, 2);
            newAsteroid.transform.localScale = Vector3.one * size;
            // if the asteroid has a rigidbody...
            newAsteroid.GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle * movementSpeed;
             //newAsteroid.GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * rotationSpeed;

			laskuri = laskuri + 2;

        }
    }
	
	// Update is called once per frame
	void Update () {
     
    }
}
