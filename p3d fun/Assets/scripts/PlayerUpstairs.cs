using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpstairs : MonoBehaviour
{

    public bool playerUpstairs = false;
    public string playerTag;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == playerTag)
        {
            playerUpstairs = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == playerTag)
        {
            playerUpstairs = false;
        }
    }
}
