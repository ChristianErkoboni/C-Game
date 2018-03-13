using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTowardMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition + Vector3.forward * 10f);
		float angle = AngleBetweenPoints (transform.position, mouseWorldPosition);
		transform.rotation = Quaternion.Euler (new Vector3 (0f, 0f, angle));
	}
	float AngleBetweenPoints (Vector3 a, Vector3 b)
	{
		return Mathf.Atan2 (a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}
