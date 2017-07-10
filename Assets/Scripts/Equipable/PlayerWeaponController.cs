using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour {
	public GameObject playerHand;
	public GameObject EquippedWeapon{ get; set;}

	Transform spawnProjectile;

	IWeapon equippedWeapon;
	CharacterStats characterStats;

	void Start(){
		spawnProjectile = transform.Find("ProjectileSpawn");
		characterStats = GetComponent<CharacterStats> ();
	}

	public void EquipWeapon(Item itemToEquip){
		if (null != EquippedWeapon) {
			characterStats.RemoveStatBonus (EquippedWeapon.GetComponent<IWeapon>().Stats);
			Destroy (playerHand.transform.GetChild(0).gameObject);
		}

		EquippedWeapon = (GameObject)Instantiate (Resources.Load<GameObject>("Weapons/"+itemToEquip.ObjectSlug),playerHand.transform.position,playerHand.transform.rotation);
		if (null != EquippedWeapon.GetComponent<IProjectileWeapon> ()) {
			EquippedWeapon.GetComponent<IProjectileWeapon> ().ProjectileSpwan = spawnProjectile; 
		}
		equippedWeapon = EquippedWeapon.GetComponent<IWeapon> ();
		equippedWeapon.Stats = itemToEquip.Stats;
		EquippedWeapon.transform.SetParent (playerHand.transform);
		characterStats.AddStatBonus (itemToEquip.Stats);
		Debug.Log (equippedWeapon.Stats [0].GetCalculatedStatValue());
	}

	public void PerformWeaponAttack(){
		if (null == equippedWeapon) {
			return;
		}
		equippedWeapon.PerformAttack ();
	}
	public void PerformSpecialWeaponAttack(){
		if (null == equippedWeapon) {
			return;
		}
		equippedWeapon.PerformSpecialAttack ();
	}
	void Update(){
		if (Input.GetKeyDown (KeyCode.X)) {
			PerformWeaponAttack ();
		}
		if (Input.GetKeyDown (KeyCode.Z)) {
			PerformSpecialWeaponAttack ();
		}
	}
}
