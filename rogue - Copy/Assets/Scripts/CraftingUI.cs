using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CraftingUI : MonoBehaviour
{
    public Inventory inventory;
    public GameObject slots;
    public CraftingRecipe Recipe;

    private void Start() {
        CreateDisplay();
    }
    private void Update() {
        
    }
    void CreateDisplay(){ 
        slots.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
        slots.transform.GetChild(0).GetComponent<Image>().sprite = Recipe.craftedItem.icon;
    
    }
    public void Craft(){
        Recipe.Craft();
        InventoryUI.Instance.UpdateDisplay();
    }
}
