using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioControl : MonoBehaviour {


	public List <AudioClip> SoundList = new List<AudioClip>(); 
	public AudioSource bg;
	public AudioSource fx;
	public AudioSource dg;
	int dhNum;
	int looksNum;


	// Use this for initialization
	void Start () {
		dhNum = 5;
		looksNum = 8;
	}
	IEnumerator Delay(){
		yield return new WaitForSeconds (2f);
		dg.clip = SoundList[2];
		dg.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input .GetKeyDown (KeyCode.Q)) {
			bg.clip = SoundList[0];
			bg.Play();
		}
		if(Input .GetKeyDown (KeyCode.W)){
			fx.clip = SoundList[4];
			fx.Play ();
			fx.loop =true;
			StartCoroutine(Delay());

		}
		if(Input .GetKeyDown (KeyCode.E)){
			fx.Stop();
			dg.Stop();
			dg.clip  = SoundList[3];
			dg.loop = false;
			dg.Play();
			bg.Stop();
			bg.clip = SoundList[1];
			bg.Play();
		}
		if(Input .GetKeyDown (KeyCode.T)){
			if(dhNum<8){
			dg.clip = SoundList[dhNum];
			dg.Play();
			dhNum++;
			}
		}
		if(Input .GetKeyDown (KeyCode.Y)){
			if(dhNum<11){
				dg.clip = SoundList[looksNum];
				dg.Play();
				looksNum++;
			}
			else{
				dhNum = 8;
			}
		}
	}
}
