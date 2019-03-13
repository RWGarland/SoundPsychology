using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public GameObject MenuBtns;
    public AudioSource WNoise;

    void Start()
    {
        MenuBtns.SetActive(false);
        WNoise = GetComponent<AudioSource>();
    }

    public void toggleMenuBtns()
    {
        MenuBtns.SetActive(!MenuBtns.activeSelf);
    }

    //allows the button to switch Tests
    public void toggleTestNo1()
    {
        SceneManager.LoadScene("Test#1");
    }
    //Switches to test 2
    public void toggleTestNo2()
    {
        SceneManager.LoadScene("Test#2");
    }

    //Loads test #3
    public void toggleTestNo3()
    {
        SceneManager.LoadScene("Test#3");
    }

    //Loads test #4
    public void toggleTestNo4()
    {
        SceneManager.LoadScene("Test2#1");
    }

    //Loads test #5
    public void toggleTestNo5()
    {
        SceneManager.LoadScene("Test2#2");
    }

    //Loads test #6
    public void toggleTestNo6()
    {
        SceneManager.LoadScene("Test2#3");
    }

    //Loads test #7
    public void toggleTestNo7()
    {
        SceneManager.LoadScene("Test3#1");
    }

    //Loads test #8
    public void toggleTestNo8()
    {
        SceneManager.LoadScene("Test3#2");
    }

    //Loads test #9
    public void toggleTestNo9()
    {
        SceneManager.LoadScene("Test3#3");
    }

    //Loads an end screen to show end of the tests
    public void toggleEndScreen()
    {
        SceneManager.LoadScene("");
    }

    //Toggles the white noise for testing
    public void togglePlay()
    {
        WNoise.Play();
    }

    //Toggles the white noise for testing
    public void togglePause()
    {
        WNoise.Stop();
    }
}
