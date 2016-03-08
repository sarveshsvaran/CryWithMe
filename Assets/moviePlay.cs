using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class moviePlay : MonoBehaviour {
	public MovieTexture mov;
	AudioSource audio ;
	bool _flag;
	// Use this for initialization
	void Start () {
		_flag = true;
		audio = GetComponent<AudioSource> ();
		mov = (GetComponent<MeshRenderer> ().materials [0].mainTexture as MovieTexture);	
		mov.Play ();
		Debug.Log (mov);
		audio.clip = mov.audioClip;
		audio.Play ();
	}

	void load()
	{
		Application.LoadLevel ("credits");
	}
	// Update is called once per frame
	void Update () {
//		if ((!mov.isPlaying) && (_flag)){
//			_flag = false;
//			GetComponent<ScreenFader>().EndScene(3);
//			Invoke ("load",5);
//		}
	}
}