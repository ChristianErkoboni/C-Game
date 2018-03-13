using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootspeed : MonoBehaviour {
	public Rigidbody rb;
	public float BulletSpeed = 20;
	public float hits;
	public GameObject Badguys;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
		Badguys = GameObject.Find ("Enemy");

	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= transform.right * Time.deltaTime * BulletSpeed;
	}
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "BadGuys") 
		{
			GameObject theEnemy = other.gameObject;
			EnemyHits enemyhits = theEnemy.GetComponent<EnemyHits> ();
			enemyhits.hits++;
		}
		if (other.gameObject.tag == "SuperBadGuy") 
		{
			GameObject SuperEnemy = other.gameObject;
			SuperEnemyHits superenemyhits = SuperEnemy.GetComponent<SuperEnemyHits> ();
			superenemyhits.hits++;
		}
		if (other.gameObject.tag == "SuperBadGuy2") 
		{
			GameObject SuperEnemy = other.gameObject;
			SuperEnemyHits2 superenemyhits = SuperEnemy.GetComponent<SuperEnemyHits2> ();
			superenemyhits.hits++;
		}
		if (other.gameObject.tag == "SuperBadGuy3") 
		{
			GameObject SuperEnemy = other.gameObject;
			SuperEnemyHits3 superenemyhits = SuperEnemy.GetComponent<SuperEnemyHits3> ();
			superenemyhits.hits++;
		}
		if (other.gameObject.tag == "MegaBadGuy") 
		{
			GameObject MegaEnemy = other.gameObject;
			MegaEnemyHits megaenemyhits = MegaEnemy.GetComponent<MegaEnemyHits> ();
			megaenemyhits.hits++;
		}
		Destroy (gameObject);
	}
}
