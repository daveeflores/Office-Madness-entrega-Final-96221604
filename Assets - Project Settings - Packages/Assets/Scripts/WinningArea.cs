using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinningArea : MonoBehaviour
{
    public TextMeshProUGUI itemsText;
    public TextMeshProUGUI itemsToWinText;
    public int items;
    public int itemsToWin;
    public GameObject UWinPanel;
    public CountdownTimer timerToStop;
    public GameObject disablePlayer;
    
    [SerializeField] AudioSource winningSound;

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Objeto"))
        {
            winningSound.Play();
            items ++;
            if (collider.gameObject.tag == "Objeto") collider.gameObject.SetActive(false);
            Debug.Log("Se sumó un item");
            
            if (items == itemsToWin)
            {
                FindObjectOfType<CountdownTimer>().enabled = false;
                disablePlayer.SetActive(false);
                UWinPanel.SetActive(true);
                Debug.Log("Ganaste");
            }
            
        }
        
            
    }


 

    void Update()
    {
        itemsText.text = items.ToString();
        itemsToWinText.text = itemsToWin.ToString();
    }
}
