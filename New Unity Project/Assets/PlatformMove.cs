using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public Transform startPosition, endPosition;
    public bool x;

    // Update is called once per frame
    void Update()
    {
        if(transform.position != startPosition.position && x)
        {
            transform.position += transform.forward * Time.deltaTime;
            transform.LookAt(startPosition);
            if(transform.position == startPosition.position)
            {
                x = false;
            }
        }
        else if(!x)
        {
            transform.position += transform.forward * Time.deltaTime;
            transform.LookAt(endPosition);
            if(transform.position == endPosition.position)
            {
                x = true;
            }
        }
    }
}
