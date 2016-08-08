using UnityEngine;
using System.Collections;

public class SunCrashScript : MonoBehaviour {

    public static PlayerScript S;


    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {

            PlayerScript.S.Destroyed();

        }


    }
}
