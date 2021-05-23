using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
 public struct Recipe{
        public Item item;
        public int amount;
}
[CreateAssetMenu(fileName = "new Craft" , menuName = "Inventory/Item/Crafted Item")]
public class CraftingRecipe : ScriptableObject
{
    public Inventory inventory;
    //crafted item
    public Item craftedItem;
    public List<Recipe> recipes;
    //item required
    private bool canCraft(){
        foreach(Recipe recipe in recipes){
            bool containCorrectIngredients = inventory.ContainsItem(recipe.item, recipe.amount);
            if(!containCorrectIngredients){
                return false;
            }
        }
        return true;
    }
    private void RemoveRecipesFromInventory(){
        foreach(Recipe recipe in recipes){
            inventory.RemoveItem(recipe.item, recipe.amount);
        }
    }

    public void Craft(){
        if(canCraft()){
            RemoveRecipesFromInventory();
            inventory.AddItem(craftedItem);
        }else{
            Debug.Log("You do not have enough Materials to craft " + craftedItem.itemName);
        }
    }
   
}
