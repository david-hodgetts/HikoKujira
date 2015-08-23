using UnityEngine;
using System.Collections;


namespace dll.Camera
{
	/// <summary>
	/// navigation component for in editor test
	/// </summary>
	public class MouseCamRotator : MonoBehaviour {

		public float rotationSensitivity;

		public float translationSpeed;

		void Update () {

			float rotationX = Input.GetAxis("Mouse Y") * rotationSensitivity;
			float rotationY = Input.GetAxis("Mouse X") * rotationSensitivity;

			transform.Rotate(0, rotationY, 0, Space.World);
			transform.Rotate(-rotationX, 0, 0 );

		
			transform.position += transform.forward * translationSpeed * Time.deltaTime;

		}
	}
}

