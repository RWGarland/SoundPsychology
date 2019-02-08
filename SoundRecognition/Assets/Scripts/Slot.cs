using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;

/*
 * This works with the drag handler to allow the child of a parent to be able to move.
 * In the reference page*/

public class Slot : MonoBehaviour, IDropHandler
{
    //sets the iamge for the cups to change for partisipant
    public Image image;
    //Sets up the sound for when a cup goes into the slot
    public AudioSource Click;
    
    //fetches the audio componant at the start 
    void start()
    {
        Click = GetComponent<AudioSource>();
    }

    public GameObject item 
    {
        get
        {           
            
            if (transform.childCount > 0) //if there is no Cup there
            {
                //changes the image of starting sprite
                image.sprite = Resources.Load<Sprite>("cross"); 
                Debug.Log("second item");
                
                //plays the audio when a cup is placed in the slot
                Click.Play();
                // only have to declare this once
              /** if() 
                {
                    Debug.Log("cup 3 has entered");
                    return transform.GetChild(0).gameObject;
                    
                }*/
            }
            if (transform.childCount > 1) //if there is 1 cup in place
            {
                //changes the image of starting sprite
                image.sprite = Resources.Load<Sprite>("Slot");
                Debug.Log("third item");

            }

            if (transform.childCount > 2) //if there is 2 cups in place
            {
                //changes the image of starting sprite
                image.sprite = Resources.Load<Sprite>("cross");
                Debug.Log("third item");

            }


            return null;

        }
    } 


  /*  void OnTriggerEnter(Collider Slot)
    {
        if (Slot.CompareTag("Cup_"))
        {
            //  Destroy(Sprite);
            Debug.Log("Can now stack");
            image.sprite = Resources.Load<Sprite>("cross");

        }


        if (Slot.CompareTag("Cup2_"))
        {
            image2.sprite = Resources.Load<Sprite>("Slot");
            Destroy(Slot.gameObject);

        }

    }*/

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