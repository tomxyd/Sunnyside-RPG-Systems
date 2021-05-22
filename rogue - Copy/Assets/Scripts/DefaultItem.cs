using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new Item", menuName = "Inventory/Item/Default")]
public class DefaultItem : Item
{
    private void Awake() {
        itemType = ItemType.Materials;
    }
    public override void Use()
    {
        Debug.Log("CLicked" + this.name);
    }
}
