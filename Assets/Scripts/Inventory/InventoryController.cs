using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour {
    public static InventoryController Instance { get; set; }
	public PlayerWeaponController playerWeaponController;
    public ConsumableController consumableController;
	public InventoryUIDetails inventoryDetailPanel;
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
		GiveItem ("sword");
		GiveItem ("potion_log");
	}
	
	public void GiveItem(string itemSlug){
		Item item = ItemDatabase.Instance.GetItem (itemSlug);
		playerItems.Add (item);
		Debug.Log ("player Items number"+playerItems.Count);
		UIEventHandler.ItemAddedToInventory (item);
	}

	public void setItemDetails(Item item,Button selecedButton){
		inventoryDetailPanel.SetItem (item,selecedButton);
	}

	public void EquipItem(Item itemToEquip){
		playerWeaponController.EquipWeapon (itemToEquip);
	}
	public void ConsumeItem(Item itemToConsume){
		consumableController.ConsumeItem (itemToConsume);
	}
}
