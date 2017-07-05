using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {
	public PlayerWeaponController playerWeaponController;
    public ConsumableController consumableController;
	public Item sword;
    public Item PotionLog;
	// Use this for initialization
	void Start () {
        playerWeaponController = GetComponent<PlayerWeaponController>();
        consumableController = GetComponent<ConsumableController>();
		List<BaseStat> swordStats = new List<BaseStat> ();
		swordStats.Add (new BaseStat(7,"power","this sword's power"));
		sword=new Item(swordStats,"Staff");

        PotionLog = new Item(new List<BaseStat>(), "potion_log", "drink this to log something", "Drink", "Log Potion", false);

	}
	
	void Update(){
        if (Input.GetKeyDown(KeyCode.V))
        {
            playerWeaponController.EquipWeapon(sword);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            consumableController.ConsumeItem(PotionLog);
        }
    }
}
