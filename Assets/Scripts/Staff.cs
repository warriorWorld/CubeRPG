using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour,IWeapon,IProjectileWeapon{
	#region IProjectileWeapon implementation

	public void CastProjectile ()
	{
		FireBall fireBallInstance = (FireBall)Instantiate (fireBall,ProjectileSpwan.position,ProjectileSpwan.rotation);
		fireBallInstance.Direction = ProjectileSpwan.forward;
 	}

	public Transform ProjectileSpwan {get;set;}

	#endregion

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
	FireBall fireBall;
	void Start(){
		fireBall = Resources.Load<FireBall> ("Weapons/Projectiles/FireBall");
		animator = GetComponent<Animator> ();
	}

}
