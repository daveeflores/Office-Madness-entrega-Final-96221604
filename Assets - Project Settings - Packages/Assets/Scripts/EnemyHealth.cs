using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth;
    public float maxHealth = 100f;
    [SerializeField] AudioSource bloop;

    public GameObject healthBarUI;
    public Slider slider;
    


    void Start()
    {
        enemyHealth = maxHealth;
        slider.value = CalculateHealth();
        
    }

    void Update()
    {

        
        slider.value = CalculateHealth();

        if (enemyHealth == maxHealth)
        {
            healthBarUI.SetActive(false);
        }
        if (enemyHealth < maxHealth)
        {
            healthBarUI.SetActive(true);
        }

        
    }

    public void DeductHealth(float deductHealth)
    {
        enemyHealth -= deductHealth;
        

        if (enemyHealth <= 0) 
        {
            
            EnemyDead();
        }
    
    }


    void EnemyDead ()
    {
        Destroy(gameObject);

    }

    float CalculateHealth()
    {
        return enemyHealth / maxHealth;
    }
}
