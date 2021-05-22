using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSystems : MonoBehaviour
{
    public Inventory inventory;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(inventory.items.Count < InventoryUI.Instance.slots.Length){
            var item = other.GetComponent<ItemPickUp>()._item;
            inventory.AddItem(item);
            Destroy(other.gameObject);
        }else{
            Debug.Log("Inventory Full");
        }
        
    }
}
