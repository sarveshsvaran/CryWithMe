using UnityEngine;
using System.Collections;

public class PartySoundManager : MonoBehaviour {

	public AudioSource partySource;
	public AudioSource tragicSource;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TragicCall(float health){
		partySource.volume = health / 500;
		tragicSource.volume = (2 - health / 50);
	}
}
