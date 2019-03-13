using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManger : MonoBehaviour {

    //sets the blank mid image
    public GameObject blankMid;
    //sets the examinor close button
    public GameObject examinerMenuClose;
    //sets the next test button
    public GameObject nextTest;
    //sets the examiner button
    public GameObject examinerBtn;
    //sets the Accuraccy score
    public GameObject accScore;
    //Gets the white noise object in level
    public GameObject wNoise;

    // Use this for initialization
    void Start()
    {
        //sets the menu assets to false at the start
        nextTest.SetActive(false);
        examinerBtn.SetActive(false);
        examinerMenuClose.SetActive(false);
        blankMid.SetActive(true);
        accScore.SetActive(false);
    }

    //Creates the function for the button to show or hide the table mid
    public void toggleBlankMid()
    {
        blankMid.SetActive(!blankMid.activeSelf);
    }

    /*creates the function to close the "pass back to examinor panel"
     allows the nextTest button to show and the examinor button becomes active
         */
    public void toggleExaminerMenu()
    {
        //Desplays UI when button is pushed
        examinerMenuClose.SetActive(!examinerMenuClose.activeSelf);
        nextTest.SetActive(!nextTest.activeSelf);
        examinerBtn.SetActive(!examinerBtn.activeSelf);
        //destroys the white noise object
        Destroy(wNoise);
    }

    //toggles the the accuraccy score for the blocks
    public void toggleAccScore()
    {
        accScore.SetActive(!accScore.activeSelf);
    }
   
}
