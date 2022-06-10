using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardShoot : MonoBehaviour
{
    public float life = 3;
    [SerializeField] float damageEnemy = 10f;
    [SerializeField] AudioSource hitSound;


    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            hitSound.Play();
            EnemyHealth enemyHealthScript = collision.transform.GetComponent<EnemyHealth>();
            enemyHealthScript.DeductHealth(damageEnemy);
            
            //Destroy(collision.gameObject);
            //Destroy(gameObject);
        }
    }
}
