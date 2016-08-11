using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EscScript : MonoBehaviour
{
    public Canvas escMenu;

    public Button restart;

    public Button jatka;

    public int level = 3;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame


    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {

            Application.LoadLevel(0);

        }

        if (Input.GetKey(KeyCode.R))
        {

            Application.LoadLevel(level);
        }

    }
}