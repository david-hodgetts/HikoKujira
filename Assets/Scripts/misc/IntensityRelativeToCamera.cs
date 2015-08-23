using UnityEngine;
using System.Collections;

public class IntensityRelativeToCamera : MonoBehaviour {

	RandomMovement randMvt;

	const float MAX_DISTANCE = 40;
	const float MIN_DISTANCE = 15;

	void Start () {
		randMvt = GetComponent<RandomMovement>();
	}
	
	void LateUpdate () {
		float distance = Vector3.Distance(Camera.main.transform.position, transform.parent.position);

		distance = Mathf.Clamp(distance, MIN_DISTANCE, MAX_DISTANCE);

		randMvt.intensity = Mathf.Lerp(0, 0.6f, 1 - ( distance / (MAX_DISTANCE - MIN_DISTANCE)));
	
	}
}
