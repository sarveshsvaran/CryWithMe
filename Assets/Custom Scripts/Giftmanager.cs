using UnityEngine;
using System.Collections;

public class Giftmanager : MonoBehaviour {
	public GameObject currentGift;
	public int speed;
	bool giftInHand;
	void Start () {
		currentGift = null;
		giftInHand = false;
	}
	void Update()
	{
		//	if (Input.GetMouseButtonDown (0)) {
		//StopCoroutine(MovetoPosition(newPosition));
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (!giftInHand) {
			if ((Physics.Raycast (ray, out hit)) && (Input.GetMouseButtonDown (0))) {
				if (hit.collider.tag != "Shop") {
					giftInHand = true;
					hit.collider.gameObject.layer = 2;
					hit.collider.gameObject.GetComponent<GiftSelector> ().giftSelected = true;
					currentGift = hit.collider.gameObject;
					//	hit.collider.gameObject.SetActive(false);
					//Debug.Log(hit.collider.gameObject.name);
				}
			}
		}
		else{
			if ((Physics.Raycast (ray, out hit)) && (Input.GetMouseButtonDown (0))) {
				if(hit.collider.tag	== "Bag"){
					if(Input.GetMouseButtonDown(0)){
						currentGift.GetComponent<GiftSelector>().giftSelected = false;
						currentGift.SetActive(false);
						giftInHand = false;
						Debug.Log("Picked Gift");
					}
				}
			}
		}
	}
}