using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem : MonoBehaviour
{ 
    public bool add;
    public Item itemToAdd;
    public InventoryManager inventory;

    void Add()
    {
        inventory.AddItemToInventory(itemToAdd);
        add = false;
    }

    private void Update()
    {
        if(add == true)
        {
            Add();
        }
    }
}
