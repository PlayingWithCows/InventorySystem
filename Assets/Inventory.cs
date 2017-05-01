using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public InventorySlot[] inventorySlots;
    public int slotAmount;
    public Itemlist itemList;
    // Use this for initialization
    void Start()

    {
        itemList = FindObjectOfType<Itemlist>();
        CreateSlots();
    }

    private void CreateSlots()
    {
        inventorySlots = new InventorySlot[slotAmount];

        for (int i = 0; i < slotAmount; i++)
        {
            inventorySlots[i] = new InventorySlot(i, itemList.GetItem(0), 0);
        }
    }

    public void AddItem(int itemID, int amount)
    {
        InventorySlot slot = CheckIfInInventory(itemID);

        if (slot != null)
        {
            slot.item = itemList.GetItem(itemID);
            slot.itemAmount += amount;
        }
    }

    private InventorySlot CheckIfInInventory(int itemID)
    {
        Debug.Log(Array.Find(inventorySlots, p => p.item.itemID == itemID));
        for (int i = 0; i < slotAmount; i++)     //returns first item slot found that matched itemID
        {
            if (inventorySlots[i].item.itemID == itemID)
            {
                return inventorySlots[i];
            }
        }

        return FindFirstEmpty();

    }

    private InventorySlot FindFirstEmpty()
    {
        for (int i = 0; i < slotAmount; i++)    //returns slot ID of first item slot that is empty
        {
            if (inventorySlots[i].item.itemID == 0)
            {
                return inventorySlots[i];
            }
        }
        return null;
    }
}
