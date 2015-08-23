using UnityEngine;
using System.Collections;

// thanks
// https://alastaira.wordpress.com/2013/08/24/the-7dfps-game-jam-augmented-reality-and-spectral-echoes/

/// <summary>
/// navigation component using the ios Gyroscope
/// </summary>
namespace dll.Camera
{
	public class CameraOrientsToGyro : MonoBehaviour
	{

		public float translationSpeed;

		Transform camParent;

		void Start ()
		{
			// Rotate the parent object by 90 degrees around the x axis

			camParent = transform.parent;
			camParent.transform.Rotate (Vector3.right, 90);
		}
	
		void Update ()
		{
			// Invert the z and w of the gyro attitude
			Quaternion rotFix = new Quaternion (Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
		
			// Now set the local rotation of the child camera object
			transform.localRotation = rotFix;

			Vector3 distanceTravelled = transform.forward * translationSpeed * Time.deltaTime;

			camParent.position += distanceTravelled;
	
		}
	}
}
