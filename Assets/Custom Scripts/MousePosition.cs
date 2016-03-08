using UnityEngine;
using System.Collections;
public class MousePosition : MonoBehaviour
{
	Vector3 newPosition;
	public int speed;
	bool _startFlag;
	Vector3 posTemp;
	void Start () {
		_startFlag = false;
		newPosition = transform.position;
		posTemp = transform.position;
	}

//	IEnumerator MovetoPosition (Vector3 target){
//		while((player.transform.position - newPosition).magnitude > 0.1)
//		{
//			player.transform.position = Vector3.MoveTowards(player.transform.position,target,5f*Time.deltaTime);
//			yield return  null;
//		}
//	}
//	void MovetoPosition(Vector3 target)
//	{
//		while((player.transform.position - target).magnitude > 0.5)
//		{
//			player.transform.position = Vector3.Lerp(player.transform.position,target,0.001f*Time.deltaTime);
//			//yield return new WaitForSeconds(0.1f);
//		}
//	}
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Q)) {
			_startFlag = true;
		}

		if(posTemp.x<transform.position.x)
		{
			var rot = transform.rotation.eulerAngles;
			rot.x= 90;
			
			rot.y = 0;
			transform.rotation = Quaternion.Euler(rot);
		}
		else if(posTemp.x>transform.position.x)
		{
			var pos = transform.rotation.eulerAngles;
			pos.x= 270;
			pos.y = 180;
			transform.rotation = Quaternion.Euler(pos);
		}
		posTemp = transform.position;
		if(_startFlag){
			//StopCoroutine(MovetoPosition(newPosition));
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				newPosition = hit.point;
				newPosition.y = 0;
//				if(transform.position.x < ray.origin.x)
//				{
//
//					
//					Debug.Log(transform.rotation);
//				}
//				else if(transform.position.x <ray.origin.x)
//				{
//					var pos = transform.rotation.eulerAngles;
//					pos.x= 270;
//					pos.y = 180;
//					transform.rotation = Quaternion.Euler(pos);
//					Debug.Log(transform.rotation);
//				}
			}
			//	}
			//StartCoroutine(MovetoPosition(newPosition));
			//player.transform.position = newPosition;
			//MovetoPosition(newPosition);
			if ((transform.position - newPosition).magnitude > 0.5) {
				transform.position = Vector3.MoveTowards (transform.position, newPosition, speed * Time.deltaTime);
				//transform.LookAt(newPosition);
			}
		}
	}
} 