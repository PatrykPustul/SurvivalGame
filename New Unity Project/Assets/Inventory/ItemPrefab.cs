using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPrefab : MonoBehaviour , IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Item item;
    static public GameObject itemInSlot;
    static public bool ifDrag;
    private Vector3 beginTransform;
    private Transform parent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemInSlot = this.gameObject;
        beginTransform = this.transform.position;
        parent = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent.parent);
        ifDrag = false;
        itemInSlot.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if(ifDrag == false)
        {
            this.transform.position = beginTransform;
            this.transform.SetParent(parent);
            itemInSlot.GetComponent<CanvasGroup>().blocksRaycasts = true;

        }

    }
}
