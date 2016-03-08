using UnityEngine;
using System.Collections;

public class PhoneManager : MonoBehaviour {

	public SoundController player;
	bool _phoneOnFlag;
	// Use this for initialization
	void Start () {
		_phoneOnFlag = false;
		player = GameObject.Find ("SoundManager").GetComponent<SoundController>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)){
			GetComponent<Animator>().SetBool("phoneOnFlag",true);
			_phoneOnFlag = true;
			player.fxPlay(6,0.7f,true);
		}
	
	}
	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			if(_phoneOnFlag){
				player.effects.Stop();
				player.bgPlay(10,0.3f,true,false);
				player.dgPlay(7,1,true);
			other.GetComponent<PlayerMoodmanager>()._phoneFlag = true;
			if(this.gameObject!=null){
				gameObject.SetActive(false);
				}
			}
		}
	}

}
