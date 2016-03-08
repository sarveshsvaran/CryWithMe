using UnityEngine;
using System.Collections;

public class GiftController : MonoBehaviour {
	public string Target;
	public string JunkSpot;
	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collisioninfo)
	{
		if (collisioninfo.collider.gameObject.name == Target) {
			Debug.Log("cheeringUp" + collisioninfo.collider.gameObject.name);
			gameObject.layer = 2;
			player.GetComponent<PlayerMotivationManager>().motivation+=10;
			Destroy(gameObject,3);
		}
		else if (collisioninfo.collider.gameObject.name == JunkSpot) {
			Debug.Log("NotCheeringUp" + collisioninfo.collider.gameObject.name);
			gameObject.layer = 2;
			player.GetComponent<PlayerMotivationManager>().motivation-=10;
			Destroy(gameObject,3);
		}
	}
}
