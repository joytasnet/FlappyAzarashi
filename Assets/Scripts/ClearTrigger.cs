using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearTrigger : MonoBehaviour
{
    GameObject gameController;

    void Start()
    {
        gameController = GameObject.FindWithTag("GameController");
    }

    void OnTriggerEnter2D(Collider2D other){
        gameController.SendMessage("IncreaseScore");
    }

}
