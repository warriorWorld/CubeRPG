using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {
	public PlayerWeaponController playerWeaponController;
	public Item sword;

	// Use this for initialization
	void Start () {
		playerWeaponController = GetComponent<PlayerWeaponController> ();
		List<BaseStat> swordStats = new List<BaseStat> ();
		swordStats.Add (new BaseStat(7,"power","this sword's power"));
		sword=new Item(swordStats,"Staff");
	}
	
	void Update(){
		if (Input.GetKeyDown (KeyCode.V)) {
			playerWeaponController.EquipWeapon (sword);
		}
	}
}
