using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperEnemyHits3 : MonoBehaviour {
	public float hits;
	public Transform Location;
	public Rigidbody Key;
	public Rigidbody Clone;
	// Use this for initialization
	void Start () {
		Location = GameObject.Find ("GreenKeySpawn").transform;
		Key = Resources.Load ("Prefabs/Key3", typeof(Rigidbody)) as Rigidbody;
	}
	
	// Update is called once per frame
	void Update () {
		if (hits == 4) 
		{
			Clone = Instantiate (Key, Location.position, Location.rotation) as Rigidbody;
			Destroy (gameObject);

		}
	}
}
