using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    public float Range = 1.0f;
    public Transform AttackPoint;
    public LayerMask PlayerLayerMask;
    bool PlayerCheck;
    public float Damage = 10f;

    public float AttackSpeed = .5f;
    float AttackTime = 0f;

    private void Update()
    {
        PlayerCheck = Physics.CheckSphere(AttackPoint.position, Range, PlayerLayerMask);

        if (PlayerCheck == true && Time.time >= AttackTime)
        {
            Attack();
            AttackTime = Time.time + 1f / AttackSpeed; 
        }
           
    }

    void Attack()
    {
        FindObjectOfType<PlayerHealth>().Health -= Damage;

        if (FindObjectOfType<PlayerHealth>().Health <=0)
        {
            FindObjectOfType<PlayerHealth>().GameOver();
        }

        UnityEngine.Debug.Log("Damage Taken");
    }

}
