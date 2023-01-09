using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;
    public Animator animator;



   

    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {

        sentences = new Queue<string>();

        
        
    }

    public void StartDialogue(Dialogue dialogue, AudioSource sound) {

        Debug.Log("Starting conversation with " + dialogue.name);

        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences) {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence(sound);

    }

    public void DisplayNextSentence(AudioSource sound) {
        if (sentences.Count==0) {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence, sound));
    }

    IEnumerator TypeSentence (string sentence, AudioSource sound) {
        dialogueText.text = "";
        sound.Play();
        foreach(char letter in sentence.ToCharArray()) {
            dialogueText.text+=letter;
            yield return null;
        }
    }

    void EndDialogue() {

        animator.SetBool("IsOpen", false);
        Debug.Log("End of conversation!");
    }




}
