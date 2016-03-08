using UnityEngine;
using System.Collections;

public class delay_load : MonoBehaviour {
	AudioSource audio;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if ((!audio.isPlaying) || (Input.GetKeyDown(KeyCode.Space))) {
			Invoke ("load", 3);
		
		}
	}

	void load()
	{
		Application .LoadLevel ("test");
	}
}
