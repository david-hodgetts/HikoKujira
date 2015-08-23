using UnityEngine;
using System.Collections;

public class AmbientMusicTrack : MonoBehaviour {

	public AudioClip[] clips;

	int _trackIndex;

	AudioSource _audioSource;

	void Start(){
		_audioSource = GetComponent<AudioSource>();
		_audioSource.clip = clips[_trackIndex];
		_audioSource.loop = true;
		_audioSource.Play();
	}

	public void PlayNextTrack (){
		_trackIndex += 1;

		if(_trackIndex < clips.Length){

			_audioSource.clip = clips[_trackIndex];
			_audioSource.Play();
		}
	}

}
