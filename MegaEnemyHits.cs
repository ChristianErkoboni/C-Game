using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaEnemyHits : MonoBehaviour {
	public float hits;
	public Transform Mega;
	public Rigidbody bullet;
	public Rigidbody clone;
	public Transform SpawnPoint;
	public GameObject WinText;
	public float Timer;
	public Transform MegaPack;
	public GameObject Pack;
	// Use this for initialization
	void Start () {
		Mega = GameObject.Find ("MegaLeftArm").transform;
		bullet = Resources.Load ("Prefabs/Bullet", typeof(Rigidbody)) as Rigidbody;
		SpawnPoint = GameObject.Find ("enemyBulletSpawnPoint19").transform;
		WinText = GameObject.Find ("WinPost");
		WinText.SetActive (false);
		MegaPack = GameObject.Find ("WalkTo").transform;
		Pack = GameObject.Find ("MegaHealthPack");
	}
	
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;
		if (hits == 5) 
		{
			transform.position = Vector3.MoveTowards (transform.position, MegaPack.position, Time.deltaTime);
		}
	}
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.name == "MegaHealthPack") 
		{
			Pack.SetActive (false);
			hits = 0;
		}
	}
	void OnTriggerStay ()
	{
		if (hits >= 5) 
		{
			if (Timer >= 2f) 
			{
				clone = Instantiate (bullet,SpawnPoint.position , SpawnPoint.rotation) as Rigidbody;
				Timer = 0;
			}
		}
		if (hits == 10) 
		{
			Destroy (gameObject);
			WinText.SetActive (true);
		}
	}
}