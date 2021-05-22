using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public enum ItemType{
        Food,
        Materials,
        Artifacts,

}


public class Item: ScriptableObject
{
    [TextArea]
    public string description;
    public string itemName;

    public ItemType itemType;
    public Sprite icon;


    public virtual void Use(){
        
    }

}
