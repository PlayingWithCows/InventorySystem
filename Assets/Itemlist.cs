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
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
