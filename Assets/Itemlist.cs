using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Itemlist : MonoBehaviour {
    public List<Item> itemsList = new List<Item>();

    

    // Use this for initialization
    void Start () {
        Item item = new Item(0, "empty", 0);
        itemsList.Add(item);

        item = new Item(1, "test", 0);
        itemsList.Add(item);

        item = new Potion(2, "TestPotion", 10, 50, 100, true);
        itemsList.Add(item);
        item = new Weapon(4, "TestWeapon", 100, 500, 1000);
        itemsList.Add(item);
    }
	
public Item GetItem(int itemID)
    {
        if (itemsList.Contains(itemsList[itemID])){
            return itemsList[itemID];
        }
        else return itemsList[0];
    }
}
