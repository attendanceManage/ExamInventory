using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryGraphics : MonoBehaviour
{
    public Transform itemParent;
    public GameObject inventoryUI;
    Inventory inventory;
    InventorySlot[] slots;

    void Start()
    {
       inventory = Inventory.instance; 
       inventory.OnItemChangedCallback += UpdateUI; 
       slots= itemParent.GetComponentsInChildren<InventorySlot>();

    }

    void Update()
    {
      if(Input.GetButtonDown("Inventory"))
      {
         inventoryUI.SetActive(!inventoryUI.activeSelf);
      }
    }
   
   void UpdateUI()
   {
      for (int i = 0; i < slots.Length; i++)
      {    
         Debug.Log(i);
         Debug.Log(i+"::"+inventory.items.Count+"::"+inventory.items); 
         if(i < inventory.items.Count)
         {
            slots[i].AddItem(inventory.items[i]);
         }else{
            slots[i].ClearSlot();
         }
      }

   }

}
