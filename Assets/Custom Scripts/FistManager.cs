using UnityEngine;
using System.Collections;

public class FistManager : MonoBehaviour {
	public GameObject myo;	
	public Texture openFist;
	public Texture grabFist;

	// Use this for initialization
	void Start () {
		myo = GameObject.Find ("Myo");
	}
	
	// Update is called once per frame
	void Update () {
		if (myo != null) {
			if ((myo.GetComponent<ThalmicMyo> ().pose == Thalmic.Myo.Pose.Fist)) {
				GetComponent<Renderer> ().material.mainTexture = grabFist;
			} else {
				GetComponent<Renderer> ().material.mainTexture = openFist;
			}
		}
	
	}
}
