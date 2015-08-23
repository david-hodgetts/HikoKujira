using UnityEngine;
using System.Collections;

public class NageoireAnim : MonoBehaviour {

	void Start(){
		var config = new GoTweenConfig().localRotation(new Vector3(-30, 0, 0)).setEaseType(GoEaseType.CubicInOut);
		config.loopType = GoLoopType.PingPong;
		config.setIterations(-1);

		float duration = 2;

		var tween = new GoTween(transform, duration, config);
		Go.addTween(tween);
	}



}
