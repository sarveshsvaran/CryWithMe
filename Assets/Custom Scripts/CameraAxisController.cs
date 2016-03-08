using UnityEngine;
using System.Collections;

public class CameraAxisController : MonoBehaviour {

	public GameObject pointer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var pos = pointer.transform.position;
		pos.y = transform.position.y;
		transform.LookAt (pos);
	}
}
