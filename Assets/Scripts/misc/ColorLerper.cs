using UnityEngine;
using System.Collections;

public class ColorLerper : MonoBehaviour {

	public Color[] colors;
	public float changeColorTime = 1;

	float t;
	float randomOffset;

	int currentIndex;
	int nextIndex;

	Renderer renderer;

	// Use this for initialization
	void Start () {
		renderer = GetComponent<Renderer>();

		t = Time.deltaTime + Random.Range(0.0f, 1.0f);
		randomOffset = Random.Range(0.0f, 0.3f);
	}
	
	// Update is called once per frame
	void Update () {
		t += Time.deltaTime + randomOffset; 
		
		if (t > changeColorTime) {
			currentIndex = (currentIndex + 1) % colors.Length;
			nextIndex = (currentIndex + 1) % colors.Length;
			t = 0.0f;
			
		}
		renderer.material.color = Color.Lerp (colors[currentIndex], colors[nextIndex], t / changeColorTime);
	}
}
