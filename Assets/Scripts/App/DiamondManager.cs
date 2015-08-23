using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DiamondManager : MonoBehaviour {

	public Transform diamondPrefab;

	public Wanderer sharkPrefab;

	public int diamondCount = 5;

	public float radius = 40;

	public float minDistanceBetweenClusters = 10;

	List<Vector3> _positions = new List<Vector3>();

	// Use this for initialization
	void Awake () {
		for (int i = 0; i < diamondCount; i++) {
			var diamond = Instantiate(diamondPrefab);


			diamond.position = RandomPosition();
			diamond.SetParent(transform);

			Wanderer shark = Instantiate(sharkPrefab).GetComponent<Wanderer>();

			shark.transform.position = diamond.position;
			shark.targetZone = diamond.transform;
		}
	}

	bool IsCloseToOtherDiamond(Vector3 p){
		foreach(var diamondPosition in _positions){
			if (Vector3.Distance(diamondPosition, p) < minDistanceBetweenClusters){
				return true;
			}
		}

		return false;
	}

	Vector3 RandomPosition(){
		Vector3 result = Random.insideUnitSphere.normalized * radius;

		while(IsCloseToOtherDiamond(result)){
			result =Random.insideUnitSphere.normalized * radius; 
		}

		_positions.Add(result);

		return result;
	}
}
