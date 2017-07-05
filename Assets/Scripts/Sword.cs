using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour ,IWeapon{
	#region IWeapon implementation
	public List<BaseStat> Stats{ get; set;}
	void IWeapon.PerformAttack ()
	{
		animator.SetTrigger("Base_Attack");
	}
	void IWeapon.PerformSpecialAttack ()
	{
		animator.SetTrigger("Special_Attack");
	}
	#endregion
	private Animator animator;
	void Start(){
		animator = GetComponent<Animator> ();
	}
	void OnTriggerEnter(Collider col){
		Debug.Log ("collide with:"+col.name);
		if (col.tag == "Enemy") {
			col.GetComponent<IEnemy>().TakeDamage(2);
		}
	}
}
