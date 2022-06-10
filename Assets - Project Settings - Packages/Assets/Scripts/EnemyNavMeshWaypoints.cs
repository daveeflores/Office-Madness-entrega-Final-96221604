
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavMeshWaypoints : MonoBehaviour
{

    [SerializeField] GameObject player;
    private float _distance;
    [SerializeField] private float distanceToAnger;
    [SerializeField] private bool isAngered;
    [SerializeField] private NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {


        if (Vector3.Distance(transform.position, target) <1)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }

}


