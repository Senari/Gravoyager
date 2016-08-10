using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextFade : MonoBehaviour {
    public Text infoText;
    public float fadeSpeed = 5f;
    public bool start = false;
    public GameObject DialogCanvas;
    // Use this for initialization

    void Awake()
    {
        infoText = DialogCanvas.GetComponentInChildren<Text> ();

        infoText.color = Color.clear;  //no color at start

    }



    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        ColorChange();

	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {

            start = true;
            Debug.Log("Something has entered this zone.");
           
        }

    }


    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {

            start = false;
        }

    }

    void ColorChange()
    {
        if (start)

        {
            infoText.color = Color.Lerp(infoText.color, Color.white, fadeSpeed * Time.deltaTime);
            print("asdsa");

        }


        if (!start)

        {
            infoText.color = Color.Lerp(infoText.color, Color.clear, fadeSpeed * Time.deltaTime);


        }

    }

}
