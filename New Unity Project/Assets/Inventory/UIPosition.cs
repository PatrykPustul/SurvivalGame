using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPosition : MonoBehaviour
{
    public GameObject inventory;
    public bool inventoryActive;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(inventoryActive)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                inventory.transform.localPosition = new Vector3(1000,0,0);
                inventoryActive = false;
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                inventory.transform.localPosition = new Vector3(0,0,0);
                inventoryActive = true;
            }
        }
    }
}
