using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Category_2 : MonoBehaviour
{

    private gameMaster gameM;

    //at the start of the scene it will find the game object of game master to get the text
    void Start()
    {
        gameM = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
    }


    void OnTriggerEnter(Collider blco)
    {
        //if block 2
        if (blco.CompareTag("Category_1"))
        {
            gameM.accuracy += 1;
            
        }
    }

}