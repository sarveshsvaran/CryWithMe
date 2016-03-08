using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DontDestroy : MonoBehaviour {

	public List <GameObject> decorations = new List<GameObject>();
	public List <GameObject> walls = new List<GameObject>();
	GameObject player;
	// Use this for initialization
	void Start () {
		decorations.AddRange(GameObject.FindGameObjectsWithTag ("Gift"));
		walls.AddRange(GameObject.FindGameObjectsWithTag ("Wall"));
		player = GameObject.FindGameObjectWithTag ("Player");

	}
	
	// Update is called once per frame
	void Update () {
	}

	void load()
	{
		Application .LoadLevel ("BirthdayParty");
	}

	public void NextStage(){
		for (int i = 0;i<decorations.Count;i++)
		{
			decorations[i].transform.SetParent(transform);
			decorations[i].gameObject.tag = "Untagged";
			decorations[i].gameObject.layer = 2;
			
		}
		for (int i = 0;i<walls.Count;i++)
		{
			walls[i].transform.SetParent(transform);
		}
		Debug.Log("sadfsad");
		DontDestroyOnLoad (transform);
		player.gameObject.GetComponent<ScreenFader>().EndScene (1);
		Invoke ("load",5); 
	}

}
