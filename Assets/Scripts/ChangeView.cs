using UnityEngine;
using System.Collections;

public class ChangeView : MonoBehaviour {

	public GameObject target; 

	void Start() {
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("ChangeView nespecifikovany, default game object");
		}
	}


	void OnMouseDown () {
		
		TargetView.target = target;
	
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
	}
}
