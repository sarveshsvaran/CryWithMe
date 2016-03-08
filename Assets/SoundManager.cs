using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundManager : MonoBehaviour {

	public List<AudioClip> clips = new List<AudioClip>();
	public int dgclip = 0;

	SoundController soundPlay;


	// Use this for initialization
	void Start () {
		Invoke ("startDialogue",5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void startDialogue(){

		if (!soundPlay.dialogue.isPlaying) {
			soundPlay.dgPlay(dgclip,1,false);
			dgclip++;
		}
	}
}
