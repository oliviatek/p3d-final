using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITrigger : MonoBehaviour
{

    [SerializeField] private string playerTag;
    [SerializeField] private string uiText;
    // Start is called before the first frame update
    public void TriggerUI()
    {
        StartCoroutine(FindObjectOfType<UIManager>().TypeSentence(uiText, 3));
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == playerTag)
        {
            Debug.Log("entered");
            TriggerUI();
        }
    }
}
