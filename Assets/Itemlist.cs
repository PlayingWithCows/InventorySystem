using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemlist : MonoBehaviour {
    public List<Item> itemsList = new List<Item>();
	// Use this for initialization
	void Start () {
        Item item = new Item();
        item.itemID = 0;
        item.itemName = "emptyItem";
        itemsList.Add(item);

        item.itemID = 1;
        item.itemName = "testItem";
        itemsList.Add(item);

        item.itemID = 2;
        item.itemName = "Sword";
	item.itemDescription = "This is a basic sword.";
        itemsList.Add(item);

item.itemID = 3;
        item.itemName = "Health Potion";
	item.itemDescription = "This is a basic Health Potion.";
        itemsList.Add(item);

item.itemID = 4;
        item.itemName = "Mana Potion";
	item.itemDescription = "This is a basic Mana Potion.";
        itemsList.Add(item);

item.itemID =5;
        item.itemName = "Shield";
	item.itemDescription = "This is a basic wooden shield.";
        itemsList.Add(item);

item.itemID = 6;
        item.itemName = "Staff";
	item.itemDescription = "This is a basic wooden staff.";
        itemsList.Add(item);

item.itemID = 7;
        item.itemName = "Bow";
	item.itemDescription = "This is a basic short bow.";
        itemsList.Add(item);

item.itemID = 8;
        item.itemName = "Wand";
	item.itemDescription = "This is a basic magic wand.";
        itemsList.Add(item);

item.itemID = 9;
        item.itemName = "Hamburger";
	item.itemDescription = "This is a Hamburger.";
        itemsList.Add(item);
    }
	
}
