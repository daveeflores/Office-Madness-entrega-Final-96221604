using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupableItem : MonoBehaviour
{
    public string id;
    public string itemName;
    public GameObject prefab;
    private Collider _collider;

    private void Awake()
    {
        _collider = GetComponent <Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;


        _collider.enabled = false;
        Inventory.Instance.GetItem(this);
    }
}
