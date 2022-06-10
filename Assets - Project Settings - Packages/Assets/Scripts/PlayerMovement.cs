using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;
   
          
    private void FixedUpdate()
    {
        Inputs();  
    }
    
    private void Inputs()
    {
        var inputX = Input.GetAxis("Horizontal"); 
        var inputY = Input.GetAxis("Vertical");

        Move(inputY);
        Rotate(inputX);
    }

    private void Move(float input)
    {
        transform.position += -transform.right * (moveSpeed * input * Time.deltaTime);
      
    }

    private void Rotate(float input)
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * input * rotationSpeed), Space.Self);
       

    }

   
}

    