using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
   public static Inventory instance = null;
   public int space = 6;
   public delegate void OnItemChanged();
   public OnItemChanged OnItemChangedCallback;
   
   void Awake()
   { 
      if(instance!=null)
      {
         Destroy(this);
         DontDestroyOnLoad(this);      
         Debug.LogWarning("Instance not Found");
      }
       instance = this;
   }

   public List<Item> items = new List<Item>();

   public bool Add(Item item)
   {
     if(!item.isDefaultItem)
     {
        
        if(items.Count >= space)
        {
            Debug.Log("Not Enough Place");
            return false;
        }

        Debug.Log(item);
        items.Add(item);
        if(OnItemChangedCallback!=null)
        {
            OnItemChangedCallback.Invoke();
        }
            
      }
      return true;
     
   
   }

   public void Remove(Item item)
   {
      items.Remove(item);
      
        if(OnItemChangedCallback!=null)
        {
            OnItemChangedCallback.Invoke();
        }
   }      
   
}
