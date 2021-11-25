using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birds : MonoBehaviour
{
    public Vector3 destination;
    public bool flying;
    public float speed;
    void Start()
    {
        destination = new Vector3(0, 100, 0);   
    }

    // Update is called once per frame
    void Update()
    {
        if (flying)
        {
            float step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, destination, step);
            transform.parent = null;
            destination += new Vector3(UnityEngine.Random.Range(-1, +1),0, UnityEngine.Random.Range(-1, +1));
        }
    }
}
