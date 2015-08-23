using UnityEngine;
using System.Collections;

public class Whale : MonoBehaviour {

	public Transform target;


	void LateUpdate () {
		transform.position = Vector3.MoveTowards(transform.position, target.position, 0.8f);
		transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, Time.deltaTime);
	}
}
