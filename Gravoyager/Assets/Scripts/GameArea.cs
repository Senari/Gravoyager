using UnityEngine;
using System.Collections;

public class GameArea : MonoBehaviour {




	// Use this for initialization
	void Start () {

 

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {

            Destroy(other.gameObject);
            Application.LoadLevel(4);


        }


    }

}
