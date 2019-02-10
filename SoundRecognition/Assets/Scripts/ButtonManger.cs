using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManger : MonoBehaviour {

    //sets the blank mid image
    public GameObject blankMid;
    //sets the examinor close button
    public GameObject examinerMenuClose;
    //sets the next test button
    public GameObject TestNo2;

    // Use this for initialization
    void Start()
    {
        //sets the menu assets to false at the start
        TestNo2.SetActive(false);
        examinerMenuClose.SetActive(false);
        blankMid.SetActive(true);
    }

    //Creates the function for the button to show or hide the table mid
    public void toggleBlankMid()
    {
        blankMid.SetActive(!blankMid.activeSelf);
    }

    //creates the function to close the "pass back to examinor panel"
    public void toggleExaminerMenu()
    {
        examinerMenuClose.SetActive(!examinerMenuClose.activeSelf);
    }
}
