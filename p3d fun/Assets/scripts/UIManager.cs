using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour


        
{

    public Text uiText;
    public Animator animator;
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        uiText.enabled = false;
        StartCoroutine(TypeSentence("pssst...use WSAD to walk around!", 3, sound));
        
    }
/*
    IEnumerator ShowMessage(string message, float delay)
    {
        yield return new WaitForSeconds(1);
   
        uiText.enabled = true;

        yield return new WaitForSeconds(delay);
        uiText.enabled = false;
    }
*/

    public IEnumerator TypeSentence(string sentence, float delay, AudioSource sound)
    {

        animator.SetBool("IsOpen", true);
        sound.Play();


        yield return new WaitForSeconds(1);
        uiText.text = "";
        uiText.enabled = true;
        foreach (char letter in sentence.ToCharArray())
        {
            uiText.text += letter;
            yield return null;
        }

        yield return new WaitForSeconds(delay);
        animator.SetBool("IsOpen", false);
        uiText.enabled = false;
    }


}
