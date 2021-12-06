using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnCollision : MonoBehaviour
{
       void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Crow")
        {
            other.gameObject.GetComponent<AudioSource>().Play(); //audio plays
            Debug.Log("crow crows");
        }
    }
}