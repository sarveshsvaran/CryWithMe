using UnityEngine;
using System.Collections;

public class GiftSelector : MonoBehaviour {

	// Use this for initialization
	public bool giftSelected;
	void Start () {
		giftSelected = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (giftSelected) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				transform.position = hit.point;
			}
		}
	}
}
