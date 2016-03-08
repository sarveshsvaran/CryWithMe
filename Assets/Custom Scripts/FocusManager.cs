using UnityEngine;
using System.Collections;

public class FocusManager : MonoBehaviour {

	
	public GameObject currentPartyGuy;
	GameObject camera;
	// Use this for initialization
	void Start () {
		currentPartyGuy = null;
		camera = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		var pos = camera.transform.position;
		pos.y = 0;
		transform.LookAt (pos);
	
	}
	void OnTriggerEnter(Collider other){
		if(other.tag == "Enemy")
			currentPartyGuy = other.gameObject;
	}
	void OnTriggerExit(Collider other){
		if (other.tag == "Enemy") {
			if(currentPartyGuy!= null){
			if (currentPartyGuy.name == other.gameObject.name){
				currentPartyGuy = null;
			}
			}
		}
	}
}
