using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnCollision : MonoBehaviour
{
       void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Crow")
        {
            other.gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("crow crows");
        }
    }
}