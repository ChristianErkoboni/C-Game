using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour {
	public Rigidbody bullet;
	public Rigidbody clone;
	public float Timer = 2;
	// Use this for initialization
	void Start () {
		bullet = Resources.Load ("Prefabs/Bullet", typeof(Rigidbody)) as Rigidbody;
	}
	
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;
		if (Input.GetButtonDown ("Fire1")) 
		{
			if (Timer >= 2) {

				clone = Instantiate (bullet, transform.position, transform.rotation) as Rigidbody;
				Timer = 0;
			}
		}
	} 
}
