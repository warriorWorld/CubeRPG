using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class ItemDatabase : MonoBehaviour
{
    public static ItemDatabase Instance { get; set; }
    private List<Item> Items { get; set; }

    // Use this for initialization
    void Start()
    {
        if (null != Instance && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        BuildDatabase();
    }
    private void BuildDatabase()
    {
        Items = JsonConvert.DeserializeObject<List<Item>>(Resources.Load<TextAsset>("JSON/Items").ToString());
        Debug.Log("database:" + Items[0].Stats[0].StatName+"\n level is:"
            +Items[0].Stats[0].GetCalculatedStatValue() + "\n name is:"
            + Items[0].ItemName);
    }
    public Item GetItem(string itemSlug) {
        foreach (Item item in Items) {
            if (item.ObjectSlug==itemSlug) {
                return item;
            }
        }
        Debug.LogWarning("could't find item: "+itemSlug);
        return null;
    }
}
