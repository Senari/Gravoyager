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
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(-Vector3.forward * RotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.forward * RotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))

            
            rigidbody.AddForce(transform.up * MovementSpeed);
        
        if (Input.GetKey(KeyCode.DownArrow))

            Torque();
        float distancePerTime = Vector2.Distance(oldPosition, this.transform.position);
        print("Speed: " + distancePerTime * 20);

        oldPosition = this.transform.position;//This way I store my own position


        Vector3 playerpos = transform.position;

        positionX = playerpos.x;
        positionY = playerpos.y;


    }

    void Torque() {

        rigidbody.AddForce((transform.up * -1) * ReverseMovementSpeed);


    }

  

}


   
   
      