using UnityEngine;
using System.Collections;

public class Environment : MonoBehaviour {

	public int count = 100;
	public float radius = 80;
	public Transform[] prefabs;


	Transform randomPrefab{
		get 
		{
			return prefabs[Random.Range(0, prefabs.Length)];
		}
	}

	// Use this for initialization
	void Start () {
		for (int i = 0; i < count; i++) {
			var stone = Instantiate(randomPrefab);
			stone.position = Random.insideUnitSphere * radius;
			stone.SetParent(transform);
		}
	}
	
}
