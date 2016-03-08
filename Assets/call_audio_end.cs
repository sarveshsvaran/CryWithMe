//using UnityEngine;
//using System.Collections;
//
//public class call_audio_end : MonoBehaviour {
//
//	//public AudioClip otherClip;
//	AudioSource audio;
//	bool _audioFlag;
//	public string nextstage;
//
//	void play_audio()
//	{
//		_audioFlag = true;
//		audio.Play();
//	}
//	void Start() {
//		_audioFlag = false;
//		audio = GetComponent<AudioSource>();
//		Invoke ("play_audio", 3);
//
//	}
//	
//	void Update() {
//		if ((!audio.isPlaying) && _audioFlag) {
//			gameObject.GetComponent<ScreenFader>().EndScene (1);
//			Invoke ("load",5);
//		}
//	}
//	void load()
//	{
//		Application .LoadLevel (nextstage);
//	}
//
//}
