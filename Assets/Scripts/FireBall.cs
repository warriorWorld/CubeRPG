using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour {
	public Vector3 Direction{ get; set;}
	public float Range{ get; set;}
	public int Damage{ get; set;}
	private Vector3 spawnPosition;

	// Use this for initialization
	void Start () {
		Range = 5f;
		spawnPosition = transform.position;
		GetComponent<Rigidbody> ().AddForce (Direction*50f);	
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (spawnPosition,transform.position)>=Range) {
			Extinguish ();
		}
	}
	void Extinguish(){
		Destroy (gameObject);
	}
	void OnCollisionEnter(Collision col){
		Debug.Log ("collide with:"+col.transform.name);
		if (col.transform.tag == "Enemy") {
			col.transform.GetComponent<IEnemy>().TakeDamage(1);
		}
		Extinguish ();
	}

}
