//using UnityEngine;
//using System.Collections;
//using UnityStandardAssets.ImageEffects;
//
//public class HealthManager : MonoBehaviour {
//	public float Health;
//	public GameObject congaLine;
//	public GameObject mainCamera;
//	bool _enableComic;
//	public float cameraOffset;
//	public float vignetteFactor;
//	public GameObject soundManager;
//	bool _deathFlag;
//	// Use this for initialization
//	void Start () {
//		//mainCamera = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<VignetteAndChromaticAberration>().intensity;
//		Invoke ("ActivateConga",5);
//		Health = 100;
//		_enableComic = false;
//		cameraOffset = 0.4f;
//		vignetteFactor = 2.5f;
//		soundManager = GameObject.Find ("SoundManager");
//		soundManager.GetComponent<PartySoundManager>().TragicCall(Health);
//		_deathFlag = false;
//	}
//	void ActivateConga()
//	{
//		//congaLine.SetActive (true);
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if (Health<10) {
//			Health = 10;
//		}
//		
////		Collider[] hitColliders = Physics.OverlapSphere(transform.position, 10,9);
////		int i = 0;
////		while(i< hitColliders.Length)
////		{
////			hitColliders[i].gameObject.GetComponent<MeshRenderer>().enabled = true;
////		}
//		//gameObject.GetComponent<MeshRenderer>().material.SetColor ("_Color",new Color((255-Health*2.55f)/255,(Health*2.55f)/255,0,1));
//		if(Input.GetKeyDown(KeyCode.R))
//		{
//			Application.LoadLevel(Application.loadedLevel);
//		}
//		if((Health==10)){
//			GetComponent<BoxCollider>().isTrigger = false;
//			_deathFlag = true;
//			Debug.Log("HealthCritical");
////			mainCamera.GetComponent<ScreenFader>().FadeImg.enabled = true;
////			mainCamera.GetComponent<ScreenFader>().FadeToBlack();
//			mainCamera.GetComponent<ScreenFader>().EndScene(4);
//			Invoke("Load",3);
//		}
//
//	}
//	void Load(){
//		Application.LoadLevel (4);
//	}
//	void OnTriggerEnter(Collider other)
//	{
//		if (other.tag == "Enemy") {
//			mainCamera.GetComponent<VignetteAndChromaticAberration>().intensity+= vignetteFactor;
//			mainCamera.GetComponent<CameraMovementManager>().height-= cameraOffset;
//				Health -= 10f;
//			soundManager.GetComponent<PartySoundManager>().TragicCall(Health);
//		} else if (other.tag == "End"){
//			Health = 1000;
//		}
//	}
//
////	void OnGUI() {
////		if (_enableComic) {
////			float width = 600;
////			float height = 600;
////			GUI.DrawTexture (new Rect ((Screen.width / 2) - (width / 2), (Screen.height / 2) - (height / 2), width, height), aTexture);//, ScaleMode.ScaleToFit);
////		}
////	}
//}
