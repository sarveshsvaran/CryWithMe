using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InputManager : MonoBehaviour {

	public GameObject presentThought;
	public List <GameObject>thoughts = new List<GameObject>();
	GameObject[] thoughtChecker;

	// Use this for initialization
	void Start () {
		thoughtChecker = GameObject.FindGameObjectsWithTag ("Thoughts");
		for(int i = 0; i< thoughtChecker.Length;i++)
		{
			thoughts.Add(thoughtChecker[i]);
		}
	}
	
	void Update () {
		for (int i =0; i< thoughts.Count; i++) {
			if((transform.position - thoughts[i].transform.position).magnitude <4f)
			{
				thoughts[i].gameObject.GetComponent<MeshRenderer>().enabled = true;
				presentThought = thoughts[i];
				Debug.Log(presentThought);
			}
			else{
				thoughts[i].gameObject.GetComponent<MeshRenderer>().enabled = false;
				//presentThought = null;
			}
			if(thoughts[i].GetComponent<ThoughtHealthManager>().thoughtHealth<=0)
			{
				thoughts.RemoveAt(i);
			}
		}

		if(Input.GetKeyDown(KeyCode.Space))
		   {
			Debug.Log(presentThought);
			if(presentThought.GetComponent<MeshRenderer>().enabled )
			{
				presentThought.GetComponent<ThoughtHealthManager>().thoughtHealth -= 20;
				if(presentThought.GetComponent<ThoughtHealthManager>().thoughtHealth<=0)
				{
					presentThought.GetComponent<ThoughtHealthManager>().KillThought();
					thoughts.Remove(presentThought);
					presentThought = null;
				}
			}
		}
		
	}
}
