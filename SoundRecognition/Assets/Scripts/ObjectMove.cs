using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;


public class ObjectMove : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject item;

    //gets the drag sound effect when moving blocks
    public AudioSource Drag;
   
   

    Transform startParent;
    Vector3 startPosition;
    //   bool start = true;

        public void Start()
    {
        GetComponent<Collider>().enabled = true;
        //gets the componant for the audio in the block object
        Drag = GetComponent<AudioSource>();
        
    }

    //gains the infomation of the object for the user to interact with
    public void OnBeginDrag(PointerEventData eventData) 
    {
        item = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;

        //Using the canvas allows the user to grab items and then move them
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        //plays the audio for the drag sound effect
       
        Drag.Play();

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
        //turns off the collider so the counters wont go up more than they have to
        GetComponent<Collider>().enabled = false;
        //stops the drag sound effect when the block is put in a slot
        Drag.Stop();
       
    }

}

