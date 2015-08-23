using UnityEngine;
using System.Collections;

public class Wanderer : MonoBehaviour {

	public float speed = 10;

	public Transform targetZone;

	public float radius = 7;

	Vector3 _orientation;

	Vector3 _target;

	void Start () {

		_target = NextTarget();

		_orientation = transform.forward;
	}
	
	void Update () {

		float distance = Vector3.Distance(transform.position, _target);

		if(distance < 1){
			_target = NextTarget();
		}else{
			Vector3 directionToTarget = (_target - transform.position).normalized;

			Debug.DrawLine(transform.position, transform.position + directionToTarget);

			_orientation = Vector3.Slerp(_orientation, directionToTarget, Time.deltaTime * 0.5f);
			transform.rotation = Quaternion.LookRotation(_orientation);
		}


		transform.position += transform.forward * speed * Time.deltaTime;

	}

	Vector3 NextTarget(){
		Vector3 result = Random.insideUnitSphere * radius + targetZone.position;
		return result;
	}

}
