using UnityEngine;
using UnityEngine.UI; // THIS NEEDED FOR DISPLAYING TEXTS
using System.Collections;

//POINTER - to MainCamera
//DISTANCE - to TimerCanvas
public class Pointer : MonoBehaviour {

    public Transform target;
	public Text distanceToTarget = null;
	public float disappearDistance = 76;
	void Start()
	{
		
	}

    void FixedUpdate()
    {
        Vector3 difference = target.position - transform.position;
		float distance = Vector2.Distance (target.position, transform.position);
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);



		if ((distanceToTarget != null))//To not display distance when it's small
		{
			distanceToTarget.text = distance.ToString("F2");//quotes for string
			if (distance <= disappearDistance)
			{
				distanceToTarget.text = null;
			}

		}

    }
}
