using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncenseDrop : MonoBehaviour
{

    public bool hasDropped = false;
    public string incenseTag;
    public Dialogue dialogue;
    public AudioSource sound;
    public GameObject upperZone;



    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("hiiii");
        if (other.tag == incenseTag) { Debug.Log("bello"); }
        
        if (other.tag == incenseTag && hasDropped == false && upperZone.GetComponent<PlayerUpstairs>().playerUpstairs == true)
        {
     
            hasDropped = true;
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue, sound);
            
        }
    }
    // Start is called before the first frame update


}
