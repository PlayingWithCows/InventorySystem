using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot {
    public int slotID;
    public Item item;
    public int itemAmount;

    public InventorySlot (int _SlotID, Item _Item, int _ItemAmount)
    {
        this.slotID = _SlotID;
        this.item = _Item;
        this.itemAmount = _ItemAmount;
    }
}
