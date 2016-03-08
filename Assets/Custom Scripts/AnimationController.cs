using UnityEngine;
using System.Collections;
public class AnimationController : MonoBehaviour {
	Vector3 old_pos;
	public Animator anim;
	// Use this for initialization
	void Start () {
		old_pos = transform.position ;
		anim = GetComponent<Animator>();
		anim.SetBool("moveRightFlag",true);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log( (old_pos - transform.position).magnitude);
		if((old_pos - transform.position).magnitude > 0.04){
			anim.speed = 1;
			//anim.SetBool("moveRightFlag",true);
		} else {
			//anim.CrossFade("stop");
			anim.speed = 0;
			//anim.SetBool("moveRightFlag",false);
		}
		old_pos = transform.position;
	}
}