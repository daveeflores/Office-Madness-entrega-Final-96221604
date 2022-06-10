using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool open = false;
    public int doorID;
    private void Start()
    {
        EventManager.OpenDoorEvent += OpenDoorAction;
        EventManager.CloseDoorEvent += CloseDoorAction;
    }

    private void Update()
    {
        if (open == true)
        {
            Debug.Log("Door open");
            transform.gameObject.SetActive(false);
        }
      //if (open == false)
      //{
      //    Debug.Log("Door Closed");
      //    transform.gameObject.SetActive(false);
      //}
    }

    private void OpenDoorAction(int triggerID)
    {
        if(triggerID == doorID)
        open = true;
        
    }


    private void CloseDoorAction(int triggerID)
    {
        //if (!open)
        //transform.gameObject.SetActive(true);
        //No logro hacer que se ejecute el evento para cerrar la puerta con el ButtonTrigger.
        //Dejo comentado el método. 
    }


    private void OnDisable()
    {
        EventManager.OpenDoorEvent -= OpenDoorAction; 
        EventManager.CloseDoorEvent -= CloseDoorAction;
    }
}
