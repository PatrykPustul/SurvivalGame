using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public Slot[] itemsInInventory;

    private void Start()
    {
        itemsInInventory = GetComponentsInChildren<Slot>();
    }

    public void AddItemToInventory(Item item)
    {
        for (int i = 0; i < itemsInInventory.Length; i++)
        {
            if(itemsInInventory[i].itemInSlot == null)
            {
                itemsInInventory[i].AddItemToSlot(item);
                break;
            }
        }

    }
}
