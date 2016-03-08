using UnityEngine;
using System.Collections;

public class CongoChildren : MonoBehaviour {

	// Use this for initialization
	public GameObject target;
	public float speed;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.LookAt (transform.parent.transform);
	//	if(){
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed*Time.deltaTime);
	//	}
	}
}
