using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
	[SerializeField] private string playerTag;

	public Dialogue dialogue;

	
	

	public void TriggerDialogue() {

		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

	}

	public void OnTriggerEnter(Collider other){
		if(other.tag == playerTag) {
			TriggerDialogue();
		}
	}

}
