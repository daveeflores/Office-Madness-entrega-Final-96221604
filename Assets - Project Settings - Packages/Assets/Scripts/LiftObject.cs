using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftObject : MonoBehaviour
{

    public GameObject grabber;
    public GameObject pickedObject = null;
    [SerializeField] AudioSource itemSfx;


    void Update()
    {
        if (pickedObject!=null)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                itemSfx.Play();
                pickedObject.GetComponent<Rigidbody>().useGravity = true;
                pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                pickedObject.gameObject.transform.SetParent(null);
                pickedObject = null;
                
            }
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Objeto"))
        {
            if (Input.GetKeyDown(KeyCode.F) && pickedObject == null)
            {
                itemSfx.Play();
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = grabber.transform.position;
                other.gameObject.transform.SetParent(grabber.gameObject.transform);
                pickedObject = other.gameObject;
            }
        }
    }
}
