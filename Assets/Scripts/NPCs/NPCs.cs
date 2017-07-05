using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPCs : Interactable
{
	public string[] dialogue;
	public string name;
	override public    void  Interact()
    {
		DialogueSystem.Instance.AddNewDialogue (dialogue,name);
    }
}
