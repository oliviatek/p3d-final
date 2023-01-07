using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public Transform dest;
    public bool inHand = false;
    [SerializeField] private string playerTag;
    private bool inTrigger;
    public Rigidbody rb;

    private void Start()
    {
       rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.G)) && inTrigger && inHand ==false)
        {
            inHand = true;
            rb.isKinematic = true;
           // GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = dest.position;
            this.transform.parent = GameObject.Find("Destination").transform;
            
        }

        if(inHand == true && Input.GetKeyDown(KeyCode.F))
        {
            inHand = false;
            rb.useGravity = true;
            rb.isKinematic = false;
            this.transform.parent = null;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("In here");
        if (other.tag == playerTag)
        {
            inTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Exiting here");
        if (other.tag == playerTag)
        {
            inTrigger = false;

        }
    }
}
