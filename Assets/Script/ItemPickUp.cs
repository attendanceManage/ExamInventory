using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
   
   public Item item;

   public void PickUp()
   {
      Debug.Log("aaaa");
     bool wasPickedUp =  Inventory.instance.Add(item);
    
      if(wasPickedUp)
      {
        Destroy(gameObject);
      }
     
   }

   
         
   
}
