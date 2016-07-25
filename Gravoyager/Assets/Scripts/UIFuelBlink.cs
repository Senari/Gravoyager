using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIFuelBlink : MonoBehaviour {

    public Image image;
    private bool repeating = false;



    void Start()
    {
        GameObject go = GameObject.Find("UIFuelIcon");
        //if (!go)
            //return;

        image = go.GetComponent<Image>();

        
    }


    void FixedUpdate()
    {

        float fuel = PlayerScript.S.ReturnFuel();


        if (fuel <= 50f) {

            if(repeating == false) { 

                InvokeRepeating("BlinkFuel", 2, 0.3F);
                repeating = true;

            }
        }
        else
        {

            CancelInvoke();
            repeating = false;

        }
        

    }

    void BlinkFuel() {

        if (image)
            image.enabled = !image.enabled;

    }

}
