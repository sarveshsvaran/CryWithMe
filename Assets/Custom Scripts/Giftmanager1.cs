using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Giftmanager1 : MonoBehaviour {
	public GameObject currentGift;
	public int speed;
	bool giftInHand;
	int count;
	AudioSource audio;

	void Start () {
		audio = gameObject.GetComponent <AudioSource > ();
		currentGift = null;
		giftInHand = false;
		count = 0;
		audio.Play();
	}

	void load()
	{
		Application .LoadLevel ("black_screen_for_dialogue_before_game");
	}

	void Update()
	{
		//	if (Input.GetMouseButtonDown (0)) {
		//StopCoroutine(MovetoPosition(newPosition));
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (!giftInHand) {
			if ((Physics.Raycast (ray, out hit)) && (Input.GetMouseButtonDown (0))) {
				if(count<2){

				if (hit.collider.tag != "Shop"){
					giftInHand = true;
					hit.collider.gameObject.layer = 2;
					hit.collider.gameObject.GetComponent<GiftSelector> ().giftSelected = true;
					currentGift = hit.collider.gameObject;
					count++;
					//currentGift.GetComponent<Rigidbody>().useGravity = true;
					//	hit.collider.gameObject.SetActive(false);
					//Debug.Log(hit.collider.gameObject.name);
					Debug.Log (count);
					}
				}
				else{
					if (!audio.isPlaying) {
						Debug.Log ("audio stopped");
						gameObject.GetComponent<ScreenFader1>().EndScene (1);
						Invoke ("load",5);
					}
					/*
					gameObject.GetComponent<ScreenFader >().EndScene(1);
					Debug.Log ("black screen called");
					//Application.LoadLevel(2);
					Invoke ("load",5);
					*/
				}
			}
		}
		else{
			if ((Physics.Raycast (ray, out hit)) && (Input.GetMouseButtonDown (0))) {
				if((hit.collider.tag== "Bag")){
					if(Input.GetMouseButtonDown(0)){
						currentGift.GetComponent<GiftSelector>().giftSelected = false;
						//currentGift.SetActive(false);
						giftInHand = false;
						Debug.Log("Picked Gift");
						//count++;

					}
				}

			}
		}
	}
}