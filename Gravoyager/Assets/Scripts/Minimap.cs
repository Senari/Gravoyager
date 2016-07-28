using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Minimap : MonoBehaviour
{


    public GameObject minimap;

    private float minimapX;
    private float minimapY;


    public static int width;
    public static int height;


    private double minimapWidth = width * 0.3;
    private double minimapHeight = height * 0.32;



    void Start()
    {

        minimapWidth = width * 0.3;
        minimapHeight = height * 0.32;

        minimapX = minimap.transform.position.x;
        minimapY = minimap.transform.position.y;

        print("MinimapX:" + minimapX + "MinimapY:" + minimapY);


        this.transform.localPosition = new Vector3(minimapX, minimapY, 0);

    }   


    void Update()
    {



    }
}
