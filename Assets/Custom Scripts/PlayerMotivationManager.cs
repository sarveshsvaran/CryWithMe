using UnityEngine;
using System.Collections;

public class PlayerMotivationManager : MonoBehaviour {
	public int threshold2=30;
	public int threshold1=60;
	
	public float motivation = 150;
	public float reductionFactor;
	Animator main1;
	Animator anim;
	public float maxHealth = 150;
	AudioSource audio;
	
	// Use this for initialization
	void Start () {
		
		//motivation = 100;
		reductionFactor = 0.5f;
		StartCoroutine (motivationDepletor());
		main1 = GetComponent<Animator > ();
		anim =  GetComponent<Animator > ();
	}

	void load()
	{
		Application .LoadLevel (3);
		//Application.L
	}
	
	// Update is called once per frame
	IEnumerator motivationDepletor()
	{
		while(motivation>=0.5){
			motivation -= reductionFactor;
			yield return new WaitForSeconds(1f);
		}
		Debug.Log ("game over");
		Debug.Log ("audio stopped");
		gameObject.GetComponent<ScreenFader>().EndScene (2);
		Invoke ("load",5);
	}
	//adding animation controller
	void Update () {
		if (motivation < threshold1) {
			transform.position = new Vector3(2.57f,-0.81f,48.99f);
			Debug.Log("SAD");
			anim.SetBool ("MoreSad",true);
			
		}
		if (motivation < threshold2) {			
			transform.position = new Vector3(2.57f,-2.69f,49.19f);
			Debug.Log("VERYSAD");
			anim.SetBool ("MoreSad",false);
			anim.SetBool ("Saddest",true);
			//		 	var pos = transform.position;
			//			pos.y = 0.08f;
			//			transform.position = pos;
		}
		
		if (motivation > threshold1) {
			transform.position = new Vector3(2.57f,0.88f,49.81f);
			Debug.Log("SAD");
			anim.SetBool ("MoreSad",false);
			
		}
		if ((motivation > threshold2)&&((motivation < threshold1))) {
			transform.position = new Vector3(2.57f,-0.81f,48.99f);
			Debug.Log("VERYSAD");
			anim.SetBool ("MoreSad",true);
			anim.SetBool ("Saddest",false);
			//		 	var pos = transform.position;
			//			pos.y = 0.08f;
			//			transform.position = pos;
		}

		//		float color =(int)Mathf.Clamp (motivation, 150, 255);
		//		RenderSettings.ambientLight = new Color (color,color,color,255);
		Debug.Log ("light "+ (float)Mathf.Clamp (motivation/maxHealth, 0.5f, 1));
		RenderSettings.ambientIntensity = (float)Mathf.Clamp (motivation/maxHealth, 0.4f, 1);
		
	}
}
