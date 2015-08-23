using UnityEngine;
using System.Collections;
using dll.Camera;

public class Bootstrap : MonoBehaviour {


	/// <summary>
	/// disable unused navigation system according to platform we are running on
	/// </summary>
	void Awake () {

		if(Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.WindowsEditor){
			FindObjectOfType<CameraOrientsToGyro>().enabled = false;
			Debug.Log("stoping gyro");
		}

#if UNITY_IOS
		if(Application.platform != RuntimePlatform.OSXEditor){
			FindObjectOfType<MouseCamRotator>().enabled = false;
			Debug.Log("stoping Mouse");
		}
#endif
	
	}
	
}
