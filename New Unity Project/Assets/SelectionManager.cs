using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 5f))
        {
            var thing = hit.transform;
            if(thing.GetComponent<Item>())
            {
                Debug.Log(thing.GetComponent<Item>().name);
                if(Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(thing.gameObject);
                    Debug.Log("I Got You");
                }
            }
        }
    }
}
