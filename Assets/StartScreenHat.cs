using UnityEngine;
using System.Collections;

public class StartScreenHat : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
				other.GetComponent<PlayerHatMoodManager>()._hatOn = true;
				if(this.gameObject!=null){
					gameObject.SetActive(false);
			}
		}
	}
}
