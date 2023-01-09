using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncenseDrop : MonoBehaviour
{

    public bool hasDropped = false;
    public string incenseTag;
    public Dialogue dialogue;
    public AudioSource sound;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == incenseTag && hasDropped == false)
        {
            hasDropped = true;
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue, sound);
            
        }
    }
    // Start is called before the first frame update


}
