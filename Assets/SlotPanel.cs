using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotPanel : MonoBehaviour {

    public GameObject invSlot;
    public Inventory playerInv;

    public List<InvSlot> UIInventorySlots = new List<InvSlot>();

     void Start()
    {
        for (int i = 0; i < playerInv.slotAmount; i++)
        {
            
            GameObject newSlot = Instantiate(invSlot);
            newSlot.transform.SetParent(transform);
            UIInventorySlots.Add(newSlot.GetComponent<InvSlot>());
            UIInventorySlots[i].slotID = i;
            UIInventorySlots[i].itemName = "";
            UIInventorySlots[i].itemAmount = 0;
            
        }
       
    }

     void Update()
    {
        foreach(InvSlot slot in UIInventorySlots)
        {
            slot.itemName = playerInv.inventorySlots[slot.slotID].item.itemName;
            slot.itemAmount = playerInv.inventorySlots[slot.slotID].itemAmount;
            slot.UpdateText();
        }
    }
}
