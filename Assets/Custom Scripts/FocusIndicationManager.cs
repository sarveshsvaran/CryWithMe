using UnityEngine;
using System.Collections;

public class FocusIndicationManager : MonoBehaviour {

	public GameObject pointer;
	public GameObject indicator;
	public GameObject myo;
	public bool _handBusy;
	public GameObject currentObject;
	public GameObject camera;
	Behaviour halo;


	// Use this for initialization
	void Start () {
		_handBusy = false;
		myo = GameObject.Find ("Myo");
	}
	void Update() {
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		Debug.DrawRay(transform.position, fwd*40, Color.red);
		RaycastHit hit;
		if (Physics.Raycast(transform.position,fwd, out hit)) {
			Debug.Log ("rotation"+hit.collider.transform.rotation.eulerAngles);
			pointer.transform.rotation = hit.collider.transform.rotation;
			Debug.Log ("hit " + hit.collider.gameObject);
			if (hit.collider.gameObject != null){
				//indicator.transform.position = hit.point;
				var pos = hit.point;
				//pos.z = hit.point.z - 1f;
				//pos = Vector3.MoveTowards(transform.position,camera.transform.position,1f);
				pointer.transform.position = pos;
				var pos1 = hit.point;
				pos1.y = 0;
				//indicator.transform.position = pos1;
				if(currentObject!=null){
					//pointer.transform.rotation = hit.collider.gameObject.transform.rotation;
					//pointer.transform.LookAt(camera.transform.localPosition);
					pointer.transform.rotation = hit.collider.transform.rotation;
					Debug.Log("hits");
				//	currentObject.transform.localRotation = hit.collider.gameObject.transform.rotation;
				}
				//Debug.Log(hit.collider.name);
			}
			if(!_handBusy){
				if((myo.GetComponent<ThalmicMyo>().pose == Thalmic.Myo.Pose.Fist)&& hit.collider.gameObject.tag == "Gift"){
					currentObject = hit.collider.gameObject;
					currentObject.transform.position = pointer.transform.position;
					currentObject.layer = 2;
					currentObject.transform.SetParent(pointer.transform);
					if((Behaviour)currentObject.GetComponent ("Halo")!=null){
						halo = (Behaviour)currentObject.GetComponent ("Halo");
						halo.enabled = false;
					}
					currentObject.GetComponent<Rigidbody>().isKinematic = true;

					_handBusy = true;
				}
			}
			if(_handBusy){
			//if(currentObject.tag == "Gift"){
			if((myo.GetComponent<ThalmicMyo>().pose != Thalmic.Myo.Pose.Fist)){
					currentObject.GetComponent<Rigidbody>().isKinematic = false;
					//hit.collider.gameObject.layer = 0;
					//hit.collider.gameObject.transform.SetParent(null);
					if(currentObject != null){
					currentObject.layer = 0;
					currentObject.transform.SetParent(null);
					_handBusy = false;
					currentObject = null;
					}
				}
//				if(currentObject!=null){
//				var rot = currentObject.transform.rotation;
//				rot.z = transform.rotation.z;
//				currentObject.transform.rotation = rot;
//					//currentObject.transform.rotation.eulerAngles.Set(currentObject.transform.rotation.x,currentObject.transform.rotation.y,transform.rotation.z);// = new Vector3(currentObject.trans);
//					//currentObject.transform.Rotate(currentObject.transform.rotation.x,currentObject.transform.rotation.y,transform.rotation.z);
//				}
			}
//			if((myo.GetComponent<ThalmicMyo>().pose == Thalmic.Myo.Pose.Fist)&& hit.collider.gameObject.tag == "Gift"){
//				var rot = hit.collider.transform.rotation;
//				rot.z = transform.rotation.z;
//				hit.collider.transform.rotation = rot;
//				Debug.Log("noOOOOOOOOOOOOOOOOOO");
//			}
			
		}
		
	}
	
}