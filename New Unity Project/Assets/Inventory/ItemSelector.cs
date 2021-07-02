using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelector : MonoBehaviour
{
    private AddItem addItem;
    // Start is called before the first frame update
    void Start()
    {
        addItem = this.gameObject.GetComponent<AddItem>();
    }

    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 5f))
        {
            var thing = hit.transform;
            if (thing.GetComponent<ItemToTake>())
            {
               if(Input.GetKeyDown(KeyCode.E))
                {
                    Debug.LogError(thing.GetComponent<ItemToTake>().item.name);
                    //addItem.itemToAdd = thing.GetComponent<ItemToTake>().item ;
                    //addItem.add = true;
                    
                }
            }
        }
    }
}
