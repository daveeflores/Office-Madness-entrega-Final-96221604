using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public int triggerID;
    [SerializeField] AudioSource triggerSource;
    
    private void OnTriggerStay(Collider collider)
    {
        if (Input.GetKeyDown(KeyCode.E) && collider.CompareTag("Player"))
        {
            triggerSource.Play();
            Debug.Log("IsTrigger");
            EventManager.StartDoorEvent(triggerID);
        }
    

    }
}
