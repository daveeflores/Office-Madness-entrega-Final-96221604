using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float speed;
    [SerializeField] private float minimumDistance;


   

    private void OpenDoorAction()
    {
      
    }
    private void Update()
    {
       
        Chase();
            
    }
    protected private void Chase()
    {
        var playerRefDistance = playerTransform.position - transform.position;

        var distanceToPlayer = playerRefDistance.magnitude;
        var dirToPlayer = playerRefDistance.normalized;
        Move(dirToPlayer, distanceToPlayer, playerRefDistance);


    }

    protected private void Move(Vector3 dir, float distanceToPlayer, Vector3 playerRefDistance)
    {
        var dirMultiplier = distanceToPlayer > minimumDistance ? 1 : -1;
        var newRotation = Quaternion.LookRotation(playerRefDistance);
        transform.rotation = newRotation;
        transform.position += dir * (dirMultiplier * (Time.deltaTime * speed));
        
    }

}