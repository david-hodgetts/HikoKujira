using UnityEngine;
using System.Collections;

public class OrientToGyro : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Input.gyro.attitude;
	
	}
}
