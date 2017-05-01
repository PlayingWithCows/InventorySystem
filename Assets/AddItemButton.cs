using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItemButton : MonoBehaviour {

    public Inventory playerInventory;

    public void AddRandomItem()
    {
        playerInventory.AddItem(Random.Range(0, playerInventory.itemList.itemsList.Count), 1);

    }
}
