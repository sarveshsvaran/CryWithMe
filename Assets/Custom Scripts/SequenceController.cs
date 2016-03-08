using UnityEngine;
using System.Collections;

public class SequenceController : MonoBehaviour {

	public GameObject soundmanager;

	SoundManager clipsmanager;

	public SoundController Player;

	// Use this for initialization
	void Start () {
		Sequence ();
		//Player = GetComponent<SoundController>();
	}
	IEnumerator PlayAudioClip(){
		while (GetComponent<SoundController>().bg.isPlaying) {
			// do nothing and keep returning while audio is still playing
			yield return null;
		}
		yield return new WaitForSeconds (2f);
		GetComponent<SoundController>().fxPlay (6,0.7f,false);
		yield return new WaitForSeconds (2f);
		GetComponent<SoundController>().dgPlay (8,1,true);
	}
	// Update is called once per frame
	void Update () {
	}

	void Sequence(){
		GetComponent<SoundController>().bgPlay (9,0.3f,true,true);
		StartCoroutine(PlayAudioClip());

	}
}
