using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour {
	public static DialogueSystem Instance{ get; set;}
	public List<string> dialogueLines=new List<string>();
	public GameObject dialoguePanel;
	private string npcName;
	Button continueBtn;
	Text dialogueText,nameText;
	int dialogueIndex;

	// Use this for initialization
	void Awake () {
		continueBtn = dialoguePanel.transform.Find ("Continue").GetComponent<Button> ();
		dialogueText = dialoguePanel.transform.Find ("Text").GetComponent<Text> ();
		nameText = dialoguePanel.transform.Find ("Name").Find("Text").GetComponent<Text> ();
		dialoguePanel.SetActive (false);

		continueBtn.onClick.AddListener (delegate {
			ContinueDialogue();
		});

		if (null != Instance && Instance != this) {
			Destroy (gameObject);
		} else {
			Instance = this;
		}
	}
	
	public void AddNewDialogue(string[] lines,string npcName){
		dialogueIndex = 0;

		dialogueLines = new List<string> (lines.Length);
		dialogueLines.AddRange (lines);

		this.npcName = npcName;

		CreateDialogue ();
	}
	public void CreateDialogue(){
		dialogueText.text=dialogueLines[dialogueIndex];
		nameText.text = npcName;
		dialoguePanel.SetActive (true);
	}
	void ContinueDialogue(){
		if (dialogueIndex < dialogueLines.Count - 1) {
			dialogueIndex++;
			CreateDialogue ();
		} else {
			dialoguePanel.SetActive (false);
		}
	}
}
