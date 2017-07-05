using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignPost : ActionItem {
	public string[] dialogue;
    override public void Interact()
    {
		DialogueSystem.Instance.AddNewDialogue (dialogue,"墓碑");
        base.Interact();
    }
}
