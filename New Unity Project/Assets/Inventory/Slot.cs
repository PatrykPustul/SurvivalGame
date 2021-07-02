using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public GameObject itemInSlot
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public GameObject itemPrefab;

    public void AddItemToSlot(Item item)
    {
        GameObject newItem = Instantiate(itemPrefab, transform.position, transform.rotation);
        newItem.transform.SetParent(this.gameObject.transform);
        newItem.GetComponent<ItemPrefab>().item = item;
        newItem.GetComponent<Image>().sprite = item.sprite;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (itemInSlot == null)
        {
            ItemPrefab.ifDrag = true;
            ItemPrefab.itemInSlot.transform.SetParent(this.transform);
            itemInSlot.GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
    }
}
