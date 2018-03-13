using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSign : MonoBehaviour {
	public GameObject Text;
	public GameObject Text2;
	// Use this for initialization
	void Start () {
		Text = GameObject.Find ("New Text");
		Text2 = GameObject.Find ("Control");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "PlatformForButton") 
		{
			Text.SetActive (false);
			Text2.SetActive (false);
		}
	}
}
