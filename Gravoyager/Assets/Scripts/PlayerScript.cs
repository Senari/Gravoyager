using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    public static PlayerScript S;

    public float positionX;
    public float positionY;

    public float gameAreaX = 400f;
    public float gameAreaY = 200f;



    public float RotateSpeed = 80f;
    public float MovementSpeed = 20f;
    public float ReverseMovementSpeed = 10f;
    public float boostCooldown = 1;
    private Rigidbody2D rigidbody;

    private Vector2 oldPosition;

    public float fuel = 100f;
    public float fuelConsumptionSpeed = 4f;
    public float refuelingSpeed = 8f;

    public Slider FuelSlider;


    void Start() {

        S = this;

        rigidbody = GetComponent<Rigidbody2D>();
        oldPosition = this.transform.position;
    }


    void FixedUpdate()
    {
        //Movement
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(-Vector3.forward * RotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.forward * RotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
        {

            if (FuelConsumption())
            {

                rigidbody.AddForce(transform.up * MovementSpeed);

            }

        }
            

        if (Input.GetKey(KeyCode.DownArrow))
        {

            if (FuelConsumption())
            {
                Reverse();
            }

        }
            

        

        float distancePerTime = Vector2.Distance(oldPosition, this.transform.position);
        //print("Speed: " + distancePerTime * 20);

        oldPosition = this.transform.position;//This way I store my own position


        Vector3 playerpos = transform.position;

        positionX = playerpos.x;
        positionY = playerpos.y;

        //GameArea();

        //Slider value
        FuelSlider.value = fuel;

    }

    void Reverse() {

        rigidbody.AddForce((transform.up * -1) * ReverseMovementSpeed);


    }

    void GameArea() {


        //Game area limitations
        //There is a bit of an bug here, you can get "inside" of the restricted area and you have to "come back" to game are to get the ship moving again
        //This can be tested by smashing into the wall and trying to get away from it, shit gets "stuck" inside the wall for as long as you "are in it"


        //X axis
        if (transform.position.x <= -gameAreaX)
        {
            transform.position = new Vector2(-gameAreaX, transform.position.y);
        }
        else if (transform.position.x >= gameAreaX)
        {
            transform.position = new Vector2(gameAreaX, transform.position.y);
        }
        // Y axis
        if (transform.position.y <= -gameAreaY)
        {
            transform.position = new Vector2(transform.position.x, -gameAreaY);
        }
        else if (transform.position.y >= gameAreaY)
        {
            transform.position = new Vector2(transform.position.x, gameAreaY);
        }


    }

    public bool FuelConsumption() {

        if (fuel > 0)
        {
            fuel = fuel - (fuelConsumptionSpeed * Time.deltaTime);
            return true;
        }
        else
        {
            return false;
        }

    }


    void OnCollisionStay2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "FuelStations")
        {

            Refueling();

        }


    }


    public void Refueling() {

        if(fuel <= 100)
        {

            fuel = fuel + (refuelingSpeed * Time.deltaTime);

        }

        


    }
    public float ReturnFuel()
    {

        return fuel;

    }

  

}


   
   
      