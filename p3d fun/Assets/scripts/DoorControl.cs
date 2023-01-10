using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    [SerializeField] private string playerTag;
    [SerializeField] private string openTrigger;
    [SerializeField] private string closeTrigger;

    private Animator animator;
    private bool inTrigger = false;
    private bool open = true;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.E)) && inTrigger)
        {
            if (open==false)
            {
             //   Debug.Log("Opening...");
                animator.SetTrigger(openTrigger);
                open = true;
            }

            else
            {
              //  Debug.Log("Closing...");
                animator.SetTrigger(closeTrigger);
                open = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("In here");
        if (other.tag == playerTag)
        {
          //  Debug.Log("Hi!");
            inTrigger = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
      //  Debug.Log("Bye!");
        if (other.tag == playerTag)
        {
            inTrigger = false;
  
        }
    }
}

