using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : Interactable {

    override public void Interact()
    {
        Debug.Log("interact with item");
    }
}
