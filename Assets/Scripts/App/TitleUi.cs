using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleUi : MonoBehaviour {

	CanvasGroup _canvasGroup;

	public enum FadeDirection {fade_in, fade_out };

	public FadeDirection fadeDirection;

	public float durationBeforeFade = 5;

	public float fadeDuration = 2;

	float _alpha;
	public float alpha{
		get{
			return _alpha;
		}
		set{
			_alpha = value;
			_canvasGroup.alpha = value;
		}
	}

	// Use this for initialization
	void Start () {

		_canvasGroup = GetComponent<CanvasGroup>();

		if(fadeDirection == FadeDirection.fade_out){
			alpha = 1; 
		}else{
			alpha = 0;
		}


		if (durationBeforeFade == 0){
			Fade ();
		}else{
			Invoke("Fade", durationBeforeFade);	
		}
	}

	void Fade(){

		float targetAlpha = fadeDirection == FadeDirection.fade_out ? 0 : 1;

		GoTweenConfig config = new GoTweenConfig().floatProp("alpha", targetAlpha).setEaseType(GoEaseType.CubicIn).onUpdate(UpdateAlpha);

		Go.addTween(new GoTween(this, fadeDuration, config));
	}

	void UpdateAlpha(AbstractGoTween t){
		_canvasGroup.alpha = alpha;
	}
}
