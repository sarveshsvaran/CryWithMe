using UnityEngine;
using System.Collections;

public class ThoughtHealthManager : MonoBehaviour {

	// Use this for initialization
	public int thoughtHealth;
	public GameObject explosion;
	void Start () {
		thoughtHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<MeshRenderer>().material.SetColor ("_Color",new Color(1,(thoughtHealth*2.55f)/255,(thoughtHealth*2.55f)/255,1));
	}

	public void KillThought()
	{
		GameObject clone = Instantiate (explosion,transform.position,Quaternion.identity) as GameObject;
		Destroy (clone,3);
		Destroy (this.gameObject);
	}
}
