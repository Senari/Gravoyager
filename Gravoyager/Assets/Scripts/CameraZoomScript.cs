using UnityEngine;
using System.Collections;

public class CameraZoomScript : MonoBehaviour {

	public float zoomSpeed = 1;
	public float targetOrtho;
	public float smoothSpeed = 2.0f;
	public float minOrtho = 1.0f;
	public float maxOrtho = 20.0f;

	void Start() {
		targetOrtho = Camera.main.orthographicSize;
	}

	void Update () {

		float scroll = Input.GetAxis ("Mouse ScrollWheel");
			if (scroll != 0.0f) {
				targetOrtho -= scroll * zoomSpeed;
				targetOrtho = Mathf.Clamp (targetOrtho, minOrtho, maxOrtho);

			//Here I'm trying to make different zooming speeds and steps to make it more comfortable 
			//to observe ship/ landing space/ planet/ system with less scrolling and waiting. t.Alex

			/*if (targetOrtho <= 9)
				zoomSpeed = 10;
				smoothSpeed = 10.0f;
				minOrtho = 2;

			if (targetOrtho >= 10)
				minOrtho = 8;
				zoomSpeed = 80;
				smoothSpeed = 80.0f;*/
		}

		Camera.main.orthographicSize = Mathf.MoveTowards (Camera.main.orthographicSize, targetOrtho, smoothSpeed * Time.deltaTime);
	}
}