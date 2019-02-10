using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    //allows the button to switch Tests
    //Switches to test 2
    public void toggleTestNo2()
    {
        SceneManager.LoadScene("Test#2");
    }

    //Switches 
    public void toggleTestNo3()
    {
        SceneManager.LoadScene("Test#3");
    }
}
