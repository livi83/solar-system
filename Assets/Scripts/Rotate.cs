using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public Transform target; 
	public int speed; 
	
	void Start() {
		if (target == null) 
		{
			target = this.gameObject.transform;
			Debug.Log ("Rotate nesecifikovany");
		}
	}

	void Update () {
		transform.RotateAround(target.transform.position,target.transform.up,speed * Time.deltaTime);
	}
}
