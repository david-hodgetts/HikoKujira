using UnityEngine;
using System.Collections;

public class DiamondCluster : MonoBehaviour {

	public Transform diamondPrefab;

	AppManager _appManager;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 50; i++) {
			var diamond = Instantiate(diamondPrefab);

			diamond.position = transform.position + Random.insideUnitSphere * 1.0f;
			diamond.localScale = Vector3.one * Random.Range(0.5f, 2f);
			diamond.SetParent(transform);
		}

		_appManager = FindObjectOfType<AppManager>();
	}

	public void AnimateToTarget(Transform target){

		transform.scaleTo(0.5f, Vector3.one * 0.05f);


		// hackety hack
		GetComponent<SphereCollider>().enabled = false;


		StartCoroutine(FollowTarget(target));
	}

	IEnumerator FollowTarget(Transform target){
		float distance = Vector3.Distance(transform.position, target.position);

		while(distance > 0.2f){

			Vector3 vecToTarget = target.position - transform.position;

			transform.position += vecToTarget * 0.3f;

			yield return null;

			distance = Vector3.Distance(transform.position, target.position);
		}
		transform.position = target.position;
		transform.SetParent(target);

		_appManager.OnDiamondPicked();
	}
	
}
