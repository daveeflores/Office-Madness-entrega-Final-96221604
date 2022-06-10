using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemsUI : MonoBehaviour
{

    private TextMeshProUGUI itemsText;
    private TextMeshProUGUI totalItemsText;

    private void Start()
    {
        itemsText = GetComponent<TextMeshProUGUI>();
        totalItemsText =GetComponent<TextMeshProUGUI>();
    }


   
}
