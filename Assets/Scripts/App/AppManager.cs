using UnityEngine;
using System;
using System.Collections;

public class AppManager : MonoBehaviour {
	public GameObject whiteFade;

	int diamondCount;

	AmbientMusicTrack _musicTrack;

	void Start(){
		diamondCount = FindObjectOfType<DiamondManager>().diamondCount;

		_musicTrack = FindObjectOfType<AmbientMusicTrack>();
	}

	public void OnDiamondPicked(){
		diamondCount -= 1;

		_musicTrack.PlayNextTrack();

		if (diamondCount == 0){
			whiteFade.SetActive(true);
			Invoke ("LaunchEndGame", 3);
		}
	}

	void LaunchEndGame(){
		Application.LoadLevel("EndGame");
	}
}
