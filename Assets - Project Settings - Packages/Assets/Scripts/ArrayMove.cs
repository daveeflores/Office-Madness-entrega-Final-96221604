using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMove : MonoBehaviour

{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private float minimumDistanceToWaypoint = 1;
    private int _index = 0;



    private void Update()
    {
        Patrol();
    }

    private void Patrol()
    {
        var initialDistance = waypoints[_index].position - transform.position;
        var dir = initialDistance.normalized;


        transform.LookAt(waypoints[_index].position);
        transform.position += moveSpeed * Time.deltaTime * dir;

        var distanceToWaypoint = initialDistance.magnitude;


        if (distanceToWaypoint < minimumDistanceToWaypoint)
        {
            CheckNextWaypoint();
        }
    }

    private void CheckNextWaypoint()

    {
        _index++;

        if (_index == waypoints.Length)
        {
            _index = 0;
        }

    }

}


