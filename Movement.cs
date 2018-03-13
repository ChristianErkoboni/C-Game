using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public Rigidbody rb; 
	public float Kills;
	public float Timer = 180.0f;
	public GameObject Player;
	public float speed = 10f;
	public float JumpSpeed = 7f;
	public Transform Camera;
	public Quaternion Sassy;
	public Transform StartSpot;
	// Use this for initialization
	void Start () {
		rb = GameObject.Find ("Player").GetComponent<Rigidbody> ();
		Player = GameObject.Find ("Player");
		Camera = GameObject.Find ("Main Camera").transform;
		StartSpot = GameObject.Find ("SpawnAfterButton").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("a")) 
		{
			transform.localPosition -= transform.forward * Time.deltaTime * speed;

		}
		if (Input.GetKey ("w")) 
		{
			transform.localPosition -= transform.right * Time.deltaTime * speed;
		}
		if (Input.GetKey ("s")) 
		{
			transform.localPosition += transform.right * Time.deltaTime * speed;
		}
		if (Input.GetKey ("d")) 
		{
			transform.localPosition += transform.forward * Time.deltaTime * speed;
		}
		if (Input.GetKey ("space")) 
		{
			transform.localPosition += transform.up * Time.deltaTime * JumpSpeed;
		}
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "PlatformForButton") 
		{
			transform.position = StartSpot.position;
		}
	}
}
