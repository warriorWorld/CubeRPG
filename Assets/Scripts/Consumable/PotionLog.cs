using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionLog : MonoBehaviour,IConsumable {
    public void Consume()
    {
        Debug.Log("you drink a coke");
    }

    public void Consume(CharacterStats stats)
    {
        Debug.Log("you drink a coke and that give you one buff");
		Destroy (gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
