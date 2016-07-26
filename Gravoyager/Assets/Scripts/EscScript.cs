using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EscScript : MonoBehaviour
{
    public Canvas escMenu;

    public Button restart;

    public Button jatka;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame


    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {


            if (Time.timeScale == 0)
            {


                Time.timeScale = 1;
            }
            else {

                Time.timeScale = 0;

            }




        }

        if (Input.GetKey(KeyCode.R))
        {

            Application.LoadLevel(3);
        }

    }
}