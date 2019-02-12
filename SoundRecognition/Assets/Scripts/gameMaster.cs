using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {

    public int accuracy;
    //sets the text box to be used when infoamtion of pushed
    public Text accuracyText;

    //updates the accuracy number as there is no text below it will fill with just munbers
	void Update ()
    {
        accuracyText.text = ("" + accuracy);	
	}
}
