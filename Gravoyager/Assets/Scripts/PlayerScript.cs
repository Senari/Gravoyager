using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    /// <summary>
    /// 1 - The speed of the ship
    /// </summary>

    public static PlayerScript S;

    public float positionX;
    public float positionY;


    public float RotateSpeed = 80f;
    public float MovementSpeed = 20f;
    public float ReverseMovementSpeed = 10f;
    public float boostCooldown = 1;
    private Rigidbody2D rigidbody;

    private Vector2 oldPosition;

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
            rigidbody.AddForce(transform.up * MovementSpeed);
        if (Input.GetKey(KeyCode.DownArrow))
            Reverse();

        

        float distancePerTime = Vector2.Distance(oldPosition, this.transform.position);
        print("Speed: " + distancePerTime * 20);

        oldPosition = this.transform.position;//This way I store my own position


        Vector3 playerpos = transform.position;

        positionX = playerpos.x;
        positionY = playerpos.y;



        //Game area limitations
        //There is a bit of an bug here, you can get "inside" of the restricted area and you have to "come back" to game are to get the ship moving again
        //This can be tested by smashing into the wall and trying to get away from it, shit gets "stuck" inside the wall for as long as you "are in it"


        //X axis
        if (transform.position.x <= -400f)
        {
            transform.position = new Vector2(-400f, transform.position.y);
        }
        else if (transform.position.x >= 400f)
        {
            transform.position = new Vector2(400f, transform.position.y);
        }
        // Y axis
        if (transform.position.y <= -200f)
        {
            transform.position = new Vector2(transform.position.x, -200f);
        }
        else if (transform.position.y >= 200f)
        {
            transform.position = new Vector2(transform.position.x, 200f);
        }

    }

    void Reverse() {

        rigidbody.AddForce((transform.up * -1) * ReverseMovementSpeed);


    }

  

}


   
   
      