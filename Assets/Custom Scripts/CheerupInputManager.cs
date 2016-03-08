using UnityEngine;
using System.Collections;

public class CheerupInputManager : MonoBehaviour {

	// Use this for initialization

	FocusIndicationManager focusArea;
	void Start () {
		focusArea = GetComponent<FocusIndicationManager>();
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnTriggerEnter(Collider other){
		Debug.Log (focusArea.indicator.GetComponent<FocusManager>().currentPartyGuy);
		if(focusArea.indicator.GetComponent<FocusManager>().currentPartyGuy!=null){
			Debug.Log ("Done");
			focusArea.indicator.GetComponent<FocusManager>().currentPartyGuy.GetComponent<CheerFactorManager> ().cheerFactor += 10;
		}
	}

}
