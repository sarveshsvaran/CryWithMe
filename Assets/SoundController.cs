using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour {

	public AudioSource bg;
	public AudioSource effects;
	public AudioSource dialogue;
	SoundManager soundManager;

	// Use this for initialization
	void Start () {
		soundManager = GetComponent<SoundManager>();
	}
	 
	void Update () {
	
	}

	public void bgPlay(int clipNum,float volume,bool replace,bool loop){

		if (replace) {
			bg.Stop ();
			bg.clip = soundManager.clips [clipNum];
			bg.volume = volume;
			bg.Play ();
		} else {
			if(!bg.isPlaying){
				bg.clip = soundManager.clips[clipNum];
				bg.volume = volume;
				bg.Play();
			}
		}
		if (loop) {
			bg.loop = true;
		} else {
			bg.loop = false;
		}

	}

	public void fxPlay(int clipNum,float volume,bool loop){

		effects.clip = soundManager.clips[clipNum];
		effects.volume = volume;
		effects.Play();
		if (loop) {
			effects.loop = true;
		} else {
			effects.loop = false;
		}

	}
	
	public void dgPlay(int clipNum,float volume,bool replace){
		if (replace) {
			dialogue.Stop ();
			dialogue.clip = soundManager.clips [clipNum];
			dialogue.volume = volume;
			dialogue.Play ();
		} else {
			if(!dialogue.isPlaying){
				dialogue.clip = soundManager.clips[clipNum];
				dialogue.volume = volume;
				dialogue.Play();
			}
		}
		
	}

}
