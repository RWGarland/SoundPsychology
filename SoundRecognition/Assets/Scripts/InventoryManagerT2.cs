using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryManagerT2 : MonoBehaviour, IDropHandler {

    //sets audio
    public AudioSource drop;
   

    void Start ()
    {
        //Gets the audio componant for the drop sound
        drop = GetComponent<AudioSource>();
	}


    public GameObject item
    {
        get
        {
            //if the child count of the slot is more than 0
            if (transform.childCount > 0) 
            {
                //if a block is already in the spot it will go back to origenal parent
                return transform.GetChild(0).gameObject;

            }

            return null;
        }
    }

    //allows the blocks to be dropped into the slot
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            //changes where the child obeject goes so it can stay where it is.
            ObjectMove.item.transform.SetParent(transform);
            //play sound for drop
            drop.Play();
        }
    }
}
