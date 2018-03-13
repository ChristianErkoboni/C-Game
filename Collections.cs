using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour {
	public GameObject[] array1 = new GameObject[3];

	public float Collection;

	public GameObject KeyOne;
	public GameObject KeyTwo;
	public GameObject KeyThree;

	public GameObject DoorOne;

	public Transform Location;
	// Use this for initialization
	void Start () {
		DoorOne = GameObject.Find ("Door1");

		Location = GameObject.Find ("SpawnInBossZone").transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.name == "Key1(Clone)") 
		{
			array1 [0] = KeyOne;
			other.gameObject.SetActive (false);
			print ("You have collected the red key!");
			Collection = 1;
		}
		if (other.gameObject.name == "Key2(Clone)") 
		{
			array1 [1] = KeyTwo;
			other.gameObject.SetActive (false);
			print ("You have collected the blue key!");
			Collection = 2;
		}
		if (other.gameObject.name == "Key3(Clone)") 
		{
			array1 [2] = KeyThree;
			other.gameObject.SetActive (false);
			print ("You have collected the green key!");
			Collection = 3;
		}
		if (Collection == 1) 
		{
			if (other.gameObject.name == "Door1") 
			{
				Destroy (DoorOne);
			}
		}
		if (Collection == 2) 
		{
			if (other.gameObject.name == "Door2") 
			{
				Destroy (other.gameObject);
			}
		}
		if (Collection == 3) 
		{
			if (other.gameObject.name == "Door3") 
			{
				transform.position = Location.position;
			}
		}
	}
}
