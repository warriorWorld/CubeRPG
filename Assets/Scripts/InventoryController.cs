using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {
    public static InventoryController Instance { get; set; }
	public PlayerWeaponController playerWeaponController;
    public ConsumableController consumableController;

	// Use this for initialization
	void Start () {
        if (null != Instance && Instance != this)
        {
            Destroy(gameObject);
        }
        else {
            Instance = this;
        }
        playerWeaponController = GetComponent<PlayerWeaponController>();
        consumableController = GetComponent<ConsumableController>();
	}
	

}
