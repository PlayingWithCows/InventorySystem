using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvSlot: MonoBehaviour  {
    public SlotPanel slotPanel;
    public int slotID, itemAmount;
    public string itemName;

    public Text slotIDText, itemNameText, itemAmountText;

     void Start()
    {
        slotIDText = transform.FindChild("SlotIDLabel").FindChild("SlotIDText").GetComponent<Text>();
        itemNameText = transform.FindChild("ItemNameLabel").FindChild("ItemNameText").GetComponent<Text>();
        itemAmountText = transform.FindChild("AmountLabel").FindChild("AmountText").GetComponent<Text>();
    }
    public void UpdateText()
    {
        slotIDText.text = slotID.ToString();
        itemNameText.text = itemName;
        itemAmountText.text = itemAmount.ToString();
    }
}
