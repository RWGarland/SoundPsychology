using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slot3 : MonoBehaviour {

    private gameMaster gameM;


    void Start()
    {
        gameM = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();    
    }



	void OnTriggerEnter(Collider blco)
    {
        if (blco.CompareTag("Block1"))
        {
            gameM.accuracy += 1;
        }

        if (blco.CompareTag("Block2"))
        {
            gameM.accuracy += 1;
        }

        if (blco.CompareTag("Block4"))
        {
            gameM.accuracy += 1;
        }

        if (blco.CompareTag("Block5"))
        {
            gameM.accuracy += 1;
        }

        if (blco.CompareTag("Block6"))
        {
            gameM.accuracy += 1;
        }

    }



}
