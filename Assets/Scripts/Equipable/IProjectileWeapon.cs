using UnityEngine;

public interface IProjectileWeapon  {
	Transform ProjectileSpwan{ get; set;}
	void CastProjectile();
}
