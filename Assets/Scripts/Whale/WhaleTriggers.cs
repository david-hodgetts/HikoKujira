using UnityEngine;
using System.Collections;

public class WhaleTriggers : MonoBehaviour {

	public Transform diamondTarget;

	void OnTriggerEnter(Collider other){
		if(other.tag == "diamond_cluster"){
			DiamondCluster cluster = other.gameObject.GetComponent<DiamondCluster>();
			if(cluster != null){
				cluster.AnimateToTarget(diamondTarget);
			}
		}
	}
}
