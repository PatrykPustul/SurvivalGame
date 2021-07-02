using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChecker : MonoBehaviour
{
    Transform itemISee;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<Item>() && !itemISee)
        {
            itemISee = other.gameObject.transform;
            Debug.Log(other.gameObject.GetComponent<Item>().name);
            
        }

        if (Input.GetKeyDown(KeyCode.E) && itemISee)
        {
            Destroy(itemISee.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        itemISee = null;
        Debug.Log("");
    }
}
