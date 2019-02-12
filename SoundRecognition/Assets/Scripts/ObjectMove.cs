using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;


public class ObjectMove : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject item;

    Transform startParent;
    Vector3 startPosition;
    //   bool start = true;


    //gains the infomation of the object for the user to interact with
    public void OnBeginDrag(PointerEventData eventData) 
    {
        item = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;

        //Using the canvas allows the user to grab items and then move them
        GetComponent<CanvasGroup>().blocksRaycasts = false; 
      
    }


    public void OnDrag(PointerEventData eventData)
    {
        //Gets position of finger on the screen while moving the object
        transform.position = Input.mousePosition; 
    }

    //if dropped outside of its area this will make it go back to its orgenal position.
    public void OnEndDrag(PointerEventData eventData) 
    {
        item = null;

        if (transform.parent == startParent)
        {
            //sets the new parent for the object
            transform.position = startPosition; 
        }
        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }

}

