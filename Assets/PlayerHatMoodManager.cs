using UnityEngine;
using System.Collections;

public class PlayerHatMoodManager : MonoBehaviour {

	Animator anim;
	public bool _hatOn;
	bool _flag;

	bool ScreenFade;
	// Use this for initialization
	void Start () {
		ScreenFade = false;
		_flag = true;
	}

	void load()
	{
		Application .LoadLevel ("SetupBirthday");
	}

	// Update is called once per frame
	void Update () {
		if(_hatOn){
			GetComponent<Animator>().SetBool("HatOn",true);
			ScreenFade = true;
		}

		if ((ScreenFade == true)&& (_flag)) {
			_flag = false;
			gameObject.GetComponent<ScreenFader>().EndScene (1);
			Invoke ("load",5);
		}
	}
}
