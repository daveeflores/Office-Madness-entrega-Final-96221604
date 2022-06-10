using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavMove : MonoBehaviour
{

    [SerializeField] GameObject player;
    private float _distance;
    [SerializeField] private float distanceToAnger;
    [SerializeField] private bool isAngered;
    [SerializeField] private NavMeshAgent agent;


    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        _distance = Vector3.Distance(player.transform.position, this.transform.position);
        
        if (_distance <= distanceToAnger)
        {
            isAngered = true;
        }
        if (_distance > distanceToAnger)
        {
            isAngered = false;
        }

        if(isAngered)
        {
            agent.isStopped = false;
            agent.SetDestination(player.transform.position);
        }
        if (!isAngered)
        {
            agent.isStopped = true;
        }
    }
}
