using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
  public static Inventory Instance;
    private Dictionary<string, PickupableItem> _itemDictionary;

    private void Awake()
    {
        if (Instance != null)
        {
            
            Destroy(gameObject);
            return;
        }

        Instance = this;
        _itemDictionary = new Dictionary<string, PickupableItem>();
      
    }

    public void GetItem(PickupableItem itemToPickup)
    {
        _itemDictionary.Add(itemToPickup.id, itemToPickup);
        itemToPickup.gameObject.SetActive(false);
        Debug.Log(HasItem(itemToPickup.id));
        Debug.Log("Obtuviste un item");

    }

    public bool HasItem(string itemID)
    {
        return _itemDictionary.ContainsKey(itemID);
    }

    public bool HasItems(List<PickupableItem> itemsToCheck)
    {
        for (int i = 0; i < itemsToCheck.Count; i++)
        {
            var itemTocheck = itemsToCheck[i];
            if (!_itemDictionary.ContainsKey(itemTocheck.id))
            {
                return false;
            }
        }
        return true;
    }


    public PickupableItem GetItemFromPool(string idTocheck)
    {
        
        if (_itemDictionary.ContainsKey(idTocheck))
        {
            var itemToReturn = _itemDictionary[idTocheck];
            _itemDictionary.Remove(idTocheck);
            return itemToReturn;
        }

        return null;
    }
}
