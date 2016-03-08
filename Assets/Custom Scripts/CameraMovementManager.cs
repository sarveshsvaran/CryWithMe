using UnityEngine;
using System.Collections;

public class CameraMovementManager : MonoBehaviour {

	public GameObject player;
	public float height = 7.5f;

	// Use this for initialization
	void Start () {

		//player = GameObject.FindGameObjectWithTag ("Player");
		//height ;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (player == null)
			return;
		else
			{
			Vector3 velocity = Vector3.zero;
			var target = player.transform.position;
			target.y = height;
			transform.LookAt(Vector3.SmoothDamp(transform.position,target,ref velocity,0.05f));
				
			}
	}
}
