using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
	[SerializeField] private string playerTag;

	public Dialogue dialogue;
	public bool hasTriggered = false;
	public AudioSource sound;

	
	

	public void TriggerDialogue() {

		StopAllCoroutines();

		FindObjectOfType<DialogueManager>().StartDialogue(dialogue, sound);

	}

	public void OnTriggerEnter(Collider other){
		if(other.tag == playerTag && hasTriggered == false) {
			hasTriggered = true;
			TriggerDialogue();
		}
	}

}
