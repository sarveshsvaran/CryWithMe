using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SniffleRotator : MonoBehaviour {
	
	public List<AudioClip> sniffleClips = new List<AudioClip>();
	public AudioSource snifflePlayer;
	public int i;
	// Use this for initialization
	void Start () {
		i = 0;
		snifflePlayer.Play ();
		//GetComponent<ScreenFader>().
	}
	
	// Update is called once per frame
	void Update () {
		if(!snifflePlayer.isPlaying){
			i =(int) Random.Range(0,3);
			snifflePlayer.clip = sniffleClips[i];
			snifflePlayer.Play();
		}
	
	}
}
