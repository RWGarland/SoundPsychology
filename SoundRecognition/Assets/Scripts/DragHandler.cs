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
    bool start = true;


    public void OnBeginDrag(PointerEventData eventData) //Allows the user to get infotion on what they can grab
    {
        item = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;

        GetComponent<CanvasGroup>().blocksRaycasts = false; //Using the canvus allows me to grab items and then move them using the mouse
      
    }


    public void OnDrag(PointerEventData eventData)
    {

        transform.position = Input.mousePosition; //where the mouse or in this case finger will take the sprite.
    }

    public void OnEndDrag(PointerEventData eventData) //if dropped outside of its area this will make it go back to its orgenal position.
    {
        item = null;

        if (transform.parent == startParent)
        {
            transform.position = startPosition; //once the child has been moved it will stay there
        }
        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }

}

