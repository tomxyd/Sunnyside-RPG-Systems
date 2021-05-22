using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InventorySlotController : MonoBehaviour
{
    private Item _item;
    public int buttonID;
    public Inventory inventory;
    private Item GetItemID(){
        for (int i = 0; i < inventory.items.Count; i++)
        {
            if(buttonID == i){
                _item = inventory.items[i];
            }
        }
        return _item;
    }
    public void RemoveItem(){
        Debug.Log(GetItemID().itemName);
        inventory.RemoveItem(GetItemID());
    }
}
