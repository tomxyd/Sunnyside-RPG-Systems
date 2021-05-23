using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Inventory inventory;
    public GameObject[] slots;
    public Item _item;
      private void OnTriggerEnter2D(Collider2D other)
    {
        if(inventory.items.Count < slots.Length){
            inventory.AddItem(_item);
            Destroy(this.gameObject);
        }else{
            Debug.Log("Inventory Full");
        }
        
    }
}
