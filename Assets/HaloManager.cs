using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HaloManager : MonoBehaviour {

	public List<GameObject> gift = new List<GameObject>();
	public List<GameObject> frame = new List<GameObject>();
	public List<GameObject> present = new List<GameObject>();
	Behaviour halo;

	// Use this for initialization
	void Start () {
	
		gift.AddRange (GameObject.FindGameObjectsWithTag("Gift"));
//		halo = (Behaviour)GetComponent ("Halo");
//		halo.enabled = true;
		//frame.AddRange (GameObject.FindGameObjectsWithTag("Gift"));
		ListSorter ();

	}
	public void ListSorter(){
		for(int i = 0; i<gift.Count;i++){
			if(gift[i].GetComponent<GiftController>().Target == "Table"){
				present.Add(gift[i]);
			}
		}
		for(int i = 0; i<gift.Count;i++){
			if(gift[i].GetComponent<GiftController>().Target == "Trash"){
				frame.Add(gift[i]);
			//Debug.Log("Removing:" + gift[i]);
			}
		}
		UpdateHalo (1,true);
	}

	public void UpdateHalo(int x,bool set){
		if(x==0){
			for(int i = 0; i<present.Count;i++){
				if(present[i].layer!=2){
				halo = (Behaviour)present[i].GetComponent ("Halo");
				if(halo!= null){
					halo.enabled = set;
				}
			}
			}
		}
		else if(x==1){
			for(int i = 0; i<frame.Count;i++){
				if(frame[i].layer!=2){
					halo = (Behaviour)frame[i].GetComponent ("Halo");
				if(halo!= null){
					halo.enabled = set;
				}
				}
			}
		}
		StartCoroutine (delay(x,!set));

	}
	IEnumerator delay(int x,bool set){
		yield return new WaitForSeconds (3f);
		Debug.Log (x);
		if(x==0){
			for(int i = 0; i<present.Count;i++){
				if(present[i].layer!=2){
					halo = (Behaviour)present[i].GetComponent ("Halo");
					if(halo!= null){
						halo.enabled = false;
					}
				}
			}
		}
		else if(x==1){
			for(int i = 0; i<frame.Count;i++){
				if(frame[i].layer!=2){
					halo = (Behaviour)frame[i].GetComponent ("Halo");
					if(halo!= null){
						halo.enabled = false;
					}
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

		//UpdateHalo (0,true);
	
	}

}
