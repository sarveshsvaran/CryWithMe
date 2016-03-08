using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMoodmanager : MonoBehaviour {

	Animator anim;
	public bool _phoneFlag;
	public bool _breakupFlag;
	public bool _sadFlag;
	public GameObject wall;
	public bool _flag;
	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();
		_phoneFlag = false;
		_flag = true;
	
	}


	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.S)){
			_breakupFlag = true;
		}
		if(Input.GetKeyDown(KeyCode.D)){
			_sadFlag = true;
		}
		if(_phoneFlag){			
			anim.SetBool ("phoneFlag",true);
		}
		if(_breakupFlag){
			anim.SetBool ("breakupFlag",true);
		}
		if((_sadFlag)&&(_flag)){
			_flag = false;
			anim.SetBool ("sadFlag",true);
			wall.GetComponent<DontDestroy>().NextStage();
		}
	}
}
