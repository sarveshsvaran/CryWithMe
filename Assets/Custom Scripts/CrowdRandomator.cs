using UnityEngine;
using System.Collections;

public class CrowdRandomator : MonoBehaviour {
	Vector3 curPos;
	Vector3 lastPos;
	public Vector3 pos;
	void Start()
	{
		lastPos = transform.position;
		//InvokeRepeating ("Randomate",1,5);
		Randomate ();
	}
	void Randomate() {
		//var pos = Random.insideUnitSphere*15;
		pos = Random.insideUnitSphere * 3 + transform.position;
//		if ((-13 < (pos.x) || (pos.x) < 13) || (-13 < (pos.z) || (pos.z) < 13)) {
//
//		} else {
//			pos = transform.position;
//		}
		if (pos.x > 96) {
			pos.x = 94 ;
		} else if (pos.x < -13) {
			pos.x = -12;
		}else if (pos.z > 13) {
			pos.z = 12;
		} else if (pos.z < -13) {
			pos.z = -12;
		}
//		while((transform.position - pos).magnitude >0.3f)
//		{
//			transform.position = Vector3.MoveTowards(transform.position,pos,0.1f*Time.deltaTime);
//		}
		//StopCoroutine (MovetoPosition (pos));
		StartCoroutine (MovetoPosition(pos));
	}
		IEnumerator MovetoPosition (Vector3 target){
		while((transform.position - target).magnitude > 0.1f)
			{
				transform.position = Vector3.MoveTowards(transform.position,target,8f*Time.deltaTime);
				var pos = transform.position;
				pos.y = 0;
				transform.position = pos;
				yield return  null;
			}
		}
	void Update()
	{
		curPos = transform.position;
		if(curPos == lastPos) {
			//print("Not moving");
			StopAllCoroutines();
			//StopCoroutine (MovetoPosition (transform.position));
			Randomate();
		}
		lastPos = curPos;
	}
}