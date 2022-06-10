using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float Health = 100f;
    public float maxHealth = 100f;
    public new GameObject gameObject;
    public GameObject healthBarUI;
    public Slider slider;
    public GameObject healthItem;
    public GameObject gameOverPanel;



    void Start()
    {
        Health = maxHealth;
        slider.value = CalculateHealth();

    }
    void Update()
    {


        slider.value = CalculateHealth();

        if (Health == maxHealth)
        {
            healthBarUI.SetActive(false);
        }
        if (Health < maxHealth)
        {
            healthBarUI.SetActive(true);
        }


    }
    public void GameOver()
    {
        gameObject.SetActive(false);
        gameOverPanel.SetActive(true);
        Debug.Log("YOU ARE DEAD.");

    }

    float CalculateHealth()
    {
        return Health / maxHealth;
    }
}
