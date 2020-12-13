using UnityEngine;
using System.Collections;

public class TargetView : MonoBehaviour {

	static public GameObject target;

	void Start () {
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("defaultny objekt");
		}
	}
	
	void Update () {
		if (target)
			transform.LookAt(target.transform);
	}
}
