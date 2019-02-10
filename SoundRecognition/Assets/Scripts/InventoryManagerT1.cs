using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;

/*
 * This works with the drag handler to allow the child of a parent to be able to move.
 * In the reference page*/

public class InventoryManagerT1 : MonoBehaviour, IDropHandler
{
    //sets the iamge for the cups to change for partisipant
    public Image image;
    //Sets up the sound for when a cup goes into the slot
    public AudioSource Click;

    public GameObject examinerBtn;
    public GameObject examinerMenuClose;
    public GameObject examinerMenu;
    public GameObject nextTest;

    //fetches the audio componant at the start as well as hides some of the UI
    void start()
    {
        examinerBtn.SetActive (false);
        examinerMenuClose.SetActive(false);
        examinerMenu.SetActive (false);
        nextTest.SetActive(false);
        Click = GetComponent<AudioSource>();
    }

    public GameObject item 
    {
        get
        {           
            
            if (transform.childCount > 0) //if there is no Cup there
            {
                //changes the image of starting sprite
                image.sprite = Resources.Load<Sprite>("CupAssets/Test#1/Stack/Cup_Stack1"); 
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
                image.sprite = Resources.Load<Sprite>("CupAssets/Test#1/Stack/Cup_Stack2");
                Debug.Log("third item");

            }

            if (transform.childCount > 2) //if there is 2 cups in place
            {
                //changes the image of starting sprite
                image.sprite = Resources.Load<Sprite>("CupAssets/Test#1/Stack/Cup_Stack3");
                Debug.Log("forth item");

            }

            if (transform.childCount > 3) //if there is 2 cups in place
            {
                //changes the image of starting sprite
                image.sprite = Resources.Load<Sprite>("CupAssets/Test#1/Stack/Cup_Stack4");
                Debug.Log("fith item");

            }

            if (transform.childCount > 4) //if there is 2 cups in place
            {
                //changes the image of starting sprite
                image.sprite = Resources.Load<Sprite>("CupAssets/Test#1/Stack/Cup_Stack5");
                Debug.Log("sixth item");
                //when this function is called these will show on the screen
                examinerBtn.SetActive(!examinerBtn.activeSelf);
                examinerMenuClose.SetActive(!examinerMenuClose.activeSelf);
                examinerMenu.SetActive(!examinerMenu.activeSelf);
                nextTest.SetActive(!nextTest.activeSelf);
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
        //On the drop function
    public void OnDrop(PointerEventData eventData)
    {
        //if no item the object will change parents
        if (!item)
        {
            //changes where the child obeject goes so it can stay where it is.
            ObjectMove.item.transform.SetParent(transform); 
        }
       
    }
    #endregion

}