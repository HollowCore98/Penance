using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomDoorScript : MonoBehaviour
{
    [Header("Door variables")]
    [SerializeField] private Animator myDoor;
    [SerializeField] private string doorOpen, doorClose;
    [SerializeField] private bool openTrigger;
    [SerializeField] private bool closeTrigger;


    private void OnTriggerEnter(Collider other)
    {
        

        if (other.CompareTag("Player"))
        {
            Debug.Log("entra al trigger");

            if (openTrigger)
            {
                Debug.Log("open");
                myDoor.Play(doorOpen, 0, 0.0f);
                gameObject.SetActive(false);
            }
            else if (closeTrigger)
            {
                Debug.Log("close");
                myDoor.Play(doorClose, 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
              
      //falta hacer que se cierre cuando el jugador recoja el objeto del suelo y que se vuelva a abrir cuando termine el puzzle de la habitación
    }
   
    
}
