using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Invemtory", menuName = "Inventory System/ Inventory")]
public class Inventory : ScriptableObject
{
    public List<Item> items = new List<Item>();
    public List<int> itemNumber = new List<int>();

    public void AddItem(Item _item){
       if(!items.Contains(_item)){// if there is no existing item
            items.Add(_item);
            itemNumber.Add(1);
        }else{
            for (int i = 0; i < items.Count; i++)
            {
                if(items[i] == _item){
                    itemNumber[i]++;
                }
            }
        }
    }

    public void RemoveItem(Item _item){
        if(items.Contains(_item)){ //if there is no existing item
            for (int i = 0; i < items.Count; i++)
            {
                if(_item == items[i]){
                    itemNumber[i]--;
                    if(itemNumber[i] == 0){
                        items.Remove(_item);
                        itemNumber.Remove(itemNumber[i]);
                    }
                }
            }
        }
    }
}
