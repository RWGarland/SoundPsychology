using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

/*
 * This works with the drag handler to allow the child of a parent to be able to move.
 * In the reference page*/

public class Slot : MonoBehaviour, IDropHandler
{

    private Stack<IInventoryItem> mitemStack = new Stack<IInventoryItem>()

    public GameObject item
    {
        get
        {
            if (transform.childCount > 4) //if there is no object there
            {
                return transform.GetChild(4).gameObject; // this will put the child back to where the parent is so it doesnt just hover in empty space
            }
            return null;
        }
    }
    #region IdropHandler implementation
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            DragHandler.item.transform.SetParent(transform); //changes where the child obeject goes so it can stay where it is.
        }
    }
    #endregion

}