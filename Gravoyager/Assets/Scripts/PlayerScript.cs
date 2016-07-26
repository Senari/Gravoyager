﻿using UnityEngine;
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

	public float maxFuel = 100f;//Tank's capacity
	private float currentFuel;//How much fuel at the moment
    public float fuelConsumptionSpeed = 4f;
    public float refuelingSpeed = 8f;
    private float distancePerTime;//Player ship's speed
	public float crashOnSpeed;//Destroy the ship when crash speed is more than...

    public Slider FuelSlider;

    void Start() 
	{
        S = this;

        rigidbody = GetComponent<Rigidbody2D>();
        oldPosition = this.transform.position;
		currentFuel = maxFuel;//Ship's tank is loaded full at start
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

        distancePerTime = Vector2.Distance(oldPosition, this.transform.position);
        print("Absolute Speed: " + distancePerTime * 20);

        oldPosition = this.transform.position;//This way I store my own position

        Vector3 playerpos = transform.position;

        positionX = playerpos.x;
        positionY = playerpos.y;

        //GameArea();

        //Slider value
        FuelSlider.value = currentFuel;
    }

    void Reverse() 
	{
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

    public bool FuelConsumption() 
	{
        if (currentFuel > 0)
        {
            currentFuel = currentFuel - (fuelConsumptionSpeed * Time.deltaTime);
            return true;
        }
        else
            return false;
    }

	//Crash and refueling platforms
    void OnCollisionStay2D(Collision2D collider)
    {
        //For collisions on speed
        float speedCol = collider.gameObject.GetComponent<SpeedsOfObjects>().objectSpeed;//Object's speed
        float relativeSpeed = speedCol * 20 - distancePerTime * 20;//Impact speed. Object's and ship's speeds have to be multiplied by 20 to get m/s format
        print("Contact Speed was: " + relativeSpeed);

		//Relative speed is a difference of ship's and object's speed. It can be negative, that's why we also use OR state
		if ((relativeSpeed >= crashOnSpeed) || (relativeSpeed <= -crashOnSpeed))
            Destroy(gameObject);
          
		if (collider.gameObject.tag == "FuelStations")
            Refueling();//If refueling does not work, check if platform has SpeedsOfObjects script attached
    }  

    public void Refueling() 
	{
        if(currentFuel <= maxFuel)//To avoid overfueling cheat
            currentFuel = currentFuel + (refuelingSpeed * Time.deltaTime);
    }
    public float ReturnFuel()
    {
		return currentFuel;
    }
}