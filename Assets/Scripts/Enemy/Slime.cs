using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour,IEnemy {
	#region IEnemy implementation

	public void TakeDamage (int amount)
	{
		currentHealth -=amount;
		Debug.Log("enemy damage");
		if (currentHealth <= 0) {
			EnemyDie();
		}
	}

	public void PreformAttack ()
	{
		throw new System.NotImplementedException ();
	}

	#endregion

	private float currentHealth, power, toughness;
	public float maxHealth;


	// Use this for initialization
	void Start() {
		currentHealth = maxHealth;
	}

	// Update is called once per frame
	void Update() {
		
	}
	void EnemyDie()
	{
		Debug.Log("enemy die");
		Destroy(gameObject);
	}
}
