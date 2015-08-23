using UnityEngine;
using System.Collections;

public class WaterNoise : MonoBehaviour {

	float t;
	float randomOffset;
	void Start () {
		t = Random.Range(0.0f, 3.0f);
		randomOffset = Random.Range(0.0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		t += Time.deltaTime + randomOffset;

		transform.Translate(Mathf.Sin (t / 8) * 0.01f, Mathf.Sin(t / 4) * 0.01f, 0);
	
	}
}
