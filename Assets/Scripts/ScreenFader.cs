using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFader : MonoBehaviour
{

	Animator anim;
	bool isFading = false;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
	}

	public IEnumerator FadeToClear ()
	{
		isFading = true;
		anim.SetTrigger ("FadeIn");

		while (isFading)
			yield return null;
	}

	public IEnumerator FadeToBlack ()
	{
		isFading = true;
		anim.SetTrigger ("FadeOut");

		while (isFading)
			yield return null;
	}

	// Update is called once per frame
	void AnimationComplete ()
	{
		isFading = false;
	}
}
