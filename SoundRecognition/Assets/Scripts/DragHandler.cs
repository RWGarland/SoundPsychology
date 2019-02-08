using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

/*
 * Allows the user to use the mouse to move items around the canvas
 * DragHandler does throw up some errors. I am unsure how to find the solution.
 *  This has been placed in the reference placed. 
 */

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject item;

    Transform startParent;
    Vector3 startPosition;
    //   bool start = true;


    //Allows the user to get infotion on what they can grab
    public void OnBeginDrag(PointerEventData eventData) 
    {
        item = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;

        //Using the canvas allows me to grab items and then move them using the mouse
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

