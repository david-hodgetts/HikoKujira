using UnityEngine;
using System.Collections;

public class RandomMovement : MonoBehaviour {

	float t;
	float randomOffset;

	[Range(0, 1)]
	public float intensity;

	void Start () {
		t = Random.Range(0.0f, 3.0f);
		randomOffset = Random.Range(0.0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		t += Time.deltaTime + randomOffset;

		Vector3 displacement = new Vector3(Mathf.Sin (t / 2) * randomOffset, Mathf.Sin(t / 1) * 0.1f, 0) * intensity;
		
		transform.localPosition += displacement;
		
	}
}
