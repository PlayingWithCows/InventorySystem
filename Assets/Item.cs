using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    public int itemID;
    public string itemName;
    public int value;

    public Item(int ItemID, string ItemName, int Value)
    {
        itemID = ItemID;
        itemName = ItemName;
        value = Value;
    }
    public Item() // seems to be necessary for public Potion() constructor to work :/
    {
    }
}

class Potion : Item
{
    public int maxStack;
    public int power;
    public bool consumable;

    public Potion(int ItemID, string ItemName, int Value, int MaxStack, int Power, bool Consumable)
    {
        this.itemID = ItemID;
        this.itemName = ItemName;
        this.value = Value;
        this.maxStack = MaxStack;
        this.power = Power;
        this.consumable = Consumable;
    }
}

class Weapon : Item
{
    public int damage;
    public int durability;

    public Weapon(int ItemID, string ItemName, int Value, int Damage, int Durability)
    {
        this.itemID = ItemID;
        this.itemName = ItemName;
        this.value = Value;
        this.damage = Damage;
        this.durability = Durability;
     
    }
}
