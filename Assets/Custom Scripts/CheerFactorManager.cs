using UnityEngine;
using System.Collections;

public class CheerFactorManager : MonoBehaviour {

	// Use this for initialization
	GameObject player;
	public float cheerFactor = 0;
	bool _hasAffected;
	int lastnum;
	public float cheerFactorMin=20;
	Animator anim;
	GameObject camera;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		camera = GameObject.FindGameObjectWithTag ("MainCamera");
		_hasAffected = false;
		lastnum = 1;
		anim = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	IEnumerator CheerDetoriation()
	{
		_hasAffected = true;
		while(cheerFactor>0){
			cheerFactor-= (cheerFactor/100)*5f;
			yield return new WaitForSeconds(1f);
		}
		_hasAffected = false;
	}
	void Update () {
		var pos = camera.transform.position;
		pos.y = transform.position.y;
		transform.LookAt (pos);
		if (cheerFactor <= cheerFactorMin) {			
			anim.SetBool ("isInspired", false);
		} else {
			anim.SetBool ("isInspired", true);
		}
		if(cheerFactor<=0){
			cheerFactor = 0;
			PlayerMotivationUpdater(0);			
		}
		else if (cheerFactor > 0) {
			PlayerMotivationUpdater(1);
		}
		if(!_hasAffected){
			//adding animation controller
			if(cheerFactor > cheerFactorMin){
				anim.SetBool ("isInspired",true);
				Debug.Log ("cry");
				StartCoroutine(CheerDetoriation());
			}
		}
	}
	void PlayerMotivationUpdater(int num){
		if (num != lastnum) {
			lastnum = num;
			if(num == 0){
				player.GetComponent<PlayerMotivationManager>().reductionFactor += 0.5F;
			}
			else if (num == 1){
				if(player.GetComponent<PlayerMotivationManager>().reductionFactor>=0.5F){
					player.GetComponent<PlayerMotivationManager>().reductionFactor -= 0.5F;
				}
			}
		}
	}
}
