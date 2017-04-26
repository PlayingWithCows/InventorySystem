using System.Collections;
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
            inventorySlots[i] = new InventorySlot();
            inventorySlots[i].slotID = i;
            inventorySlots[i].itemAmount = 0;
            inventorySlots[i].item = itemList.itemsList[0];
        }
    }

    public void AddItem(int itemID, int amount)
    {
        int itemIndex = CheckIfInInventory(itemID);

        if (itemIndex != -1)
        {

            inventorySlots[itemIndex].itemAmount += amount;
        }
    }

    private int CheckIfInInventory(int itemID)
    {
        for (int i = 0; i < slotAmount; i++)     //returns slot ID of first item slot found that matched itemID
        {
            if (inventorySlots[i].item.itemID == itemID)
            {
                return inventorySlots[i].slotID;
            }
        }

        return -1;

    }

    private int FindFirstEmpty()
    {
        for (int i = 0; i < slotAmount; i++)    //returns slot ID of first item slot that is empty
        {
            if (inventorySlots[i].item.itemID == 0)
            {
                return inventorySlots[i].slotID;
            }
        }
        return -1;
    }
}
