using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    public static InventoryUI Instance { get; private set; }
    public Inventory inventory;
    public GameObject[] slots;
    private void Awake() {
        Instance = this;
    }
    private void Start()
    {
        UpdateDisplay();
    }
    private void Update() {
        UpdateDisplay();
    }
    void UpdateDisplay(){
       for (int i = 0; i < inventory.items.Count; i++)
       {
            slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(0).GetComponent<Image>().sprite = inventory.items[i].icon;

            slots[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = inventory.itemNumber[i].ToString("n0");

            slots[i].transform.GetChild(2).gameObject.SetActive(true);
        }

        for (int i = 0; i < slots.Length; i++)
        {
            if(i < inventory.items.Count){
                 slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = inventory.items[i].icon;

                slots[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = inventory.itemNumber[i].ToString("n0");

                slots[i].transform.GetChild(2).gameObject.SetActive(true);
            }else{
                 slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;

                slots[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 0);
                slots[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = null;

                slots[i].transform.GetChild(2).gameObject.SetActive(false);
            }
        }
    }
  
}