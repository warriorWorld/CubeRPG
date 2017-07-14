using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {
    public static InventoryController Instance { get; set; }
	public PlayerWeaponController playerWeaponController;
    public ConsumableController consumableController;
	public List<Item> playerItems = new List<Item> ();

	// Use this for initialization
	void Start () {
        if (null != Instance && Instance != this)
        {
            Destroy(gameObject);
        }
        else
         {
            Instance = this;
        }
        playerWeaponController = GetComponent<PlayerWeaponController>();
        consumableController = GetComponent<ConsumableController>();
	}
	
	public void GiveItem(string itemSlug){
		playerItems.Add (ItemDatabase.Instance.GetItem(itemSlug));
		Debug.Log ("player Items number"+playerItems.Count);
	}
	public void EquipItem(Item itemToEquip){
		playerWeaponController.EquipWeapon (itemToEquip);
	}
	public void ConsumeItem(Item itemToConsume){
		consumableController.ConsumeItem (itemToConsume);
	}
}
