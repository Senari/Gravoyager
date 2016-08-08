using UnityEngine;
using System.Collections;

public class SunScript : MonoBehaviour {

    public bool closeToSun = false;
    public float timeCloseToSun = 0;
    public float maxTimeCloseToSun = 5;

    public static PlayerScript S;

    void Update () {

        if (timeCloseToSun >= maxTimeCloseToSun) {

            PlayerScript.S.Destroyed();

        }

        if (closeToSun == true) {

            timeCloseToSun = timeCloseToSun + Time.deltaTime;

        }



	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {


            closeToSun = true;


        }


    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {

            timeCloseToSun = 0;
            closeToSun = false;


        }


    }

}
