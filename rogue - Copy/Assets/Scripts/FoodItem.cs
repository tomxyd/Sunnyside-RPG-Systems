using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new Item", menuName = "Inventory/Item/Food")]
public class FoodItem : Item
{
    public int restoreHealthPoints;
    private void Awake() {
        itemType = ItemType.Food;
    }
    public override void Use()
    {
        Debug.Log("Healed" + restoreHealthPoints);
    }
}
