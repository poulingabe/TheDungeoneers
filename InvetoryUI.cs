using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvetoryUI : MonoBehaviour
{
    private Inventory inventory; 
    private Transform itemslotcontainer;
    private Transform itemslottemplate;

    private void Awake()
    {
        itemslotcontainer = transform.Find("ItemSlotContainer"); 
        itemslottemplate = transform.Find("ItemSlotTemplate");
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        int x = 0; 
        int y = 0; 
        float itemSlotCellSise = 30f;

        foreach (Item item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemslottemplate, itemslotcontainer).GetCompontent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSise, y * itemSlotCellSise);
            x++;
            if( x > 4){
                x = 0;
                y++;
            }

        }
    }



}
