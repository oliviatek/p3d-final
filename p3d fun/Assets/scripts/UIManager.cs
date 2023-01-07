using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour

        
{

    public Text uiText;
    // Start is called before the first frame update
    void Start()
    {
        uiText.enabled = false;
        StartCoroutine(TypeSentence("pssst...use WSAD to walk around!", 3));
        
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

    public IEnumerator TypeSentence(string sentence, float delay)
    {

        yield return new WaitForSeconds(1);
        uiText.text = "";
        uiText.enabled = true;
        foreach (char letter in sentence.ToCharArray())
        {
            uiText.text += letter;
            yield return null;
        }

        yield return new WaitForSeconds(delay);
        uiText.enabled = false;
    }


}
