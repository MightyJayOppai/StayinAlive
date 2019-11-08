﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClickHandler : MonoBehaviour
{
    public void OnItemClicked()
    {
        ItemDragHandler dragHandler = gameObject.transform.Find("ItemImage").GetComponent<ItemDragHandler>();
        
        IClueItem item = dragHandler.Item;
        
        Debug.Log(item.Name);
        item.OnUse();
    }
}
