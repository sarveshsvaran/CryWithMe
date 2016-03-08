using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PartyAudioController : MonoBehaviour {

	// Use this for initialization

	public AudioSource DgPlayer;
	public List <AudioClip> soundClips = new List<AudioClip>();
	int dgCount;
	void Start () {
		dgCount = 0;
		InvokeRepeating ("PlayDg",5,Random.Range (4,7));
	
	}
	void PlayDg(){
		if(!DgPlayer.isPlaying){
			if(dgCount<7){
			DgPlayer.clip = soundClips[dgCount];
				DgPlayer.Play();
			dgCount++;
			}
			else{
				dgCount = 0;
			}
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
