using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slot5 : MonoBehaviour {

    private gameMaster gameM;

    //at the start of the scene it will find the game object of game master to get the text
    void Start()
    {
        gameM = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();    
    }

    /*if the collider comes into contact with these ojects and their tag then it will increese the
     accuracy counter by one
     */

    void OnTriggerEnter(Collider blco)
    {
        //if block 1
        if (blco.CompareTag("Block1"))
        {
            gameM.accuracy += 1;
        }

        //if block 2
        if (blco.CompareTag("Block2"))
        {
            gameM.accuracy += 1;
        }

        //if block 3
        if (blco.CompareTag("Block3"))
        {
            gameM.accuracy += 1;
        }

        //if block 4
        if (blco.CompareTag("Block4"))
        {
            gameM.accuracy += 1;
        }

        //if block 6
        if (blco.CompareTag("Block6"))
        {
            gameM.accuracy += 1;
        }

    }



}
