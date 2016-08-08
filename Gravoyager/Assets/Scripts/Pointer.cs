using UnityEngine;
using UnityEngine.UI; // THIS NEEDED FOR DISPLAYING TEXTS
using System.Collections;

//======================================
//POINTER prefab - to MainCamera
//DISTANCE text prefab - to TimerCanvas
//======================================

public class Pointer : MonoBehaviour {

    public Transform target;//Object that pointer is aimed at
	public Text distanceToTarget = null;//Text object
	public float offsetMeters;//For example planet's radius to count distance to surface
	public float disappearDistance = 5;//Distance, where distance meter will disappear
	void Start()
	{
		
	}

    void FixedUpdate()
    {
        Vector3 difference = target.position - transform.position;
		float distance = Vector2.Distance (target.position, transform.position) - offsetMeters;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);



		if ((distanceToTarget != null))//To not display distance when it's small
		{
			distanceToTarget.text = distance.ToString("F2");//quotes for string
			if (distance <= disappearDistance)
			{
				distanceToTarget.text = null;
				//Maybe destroy whole pointer as well
				Destroy(this);
			}

		}

    }
}
