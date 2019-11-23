using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueLog : MonoBehaviour
{
    private const int SLOTS = 4;
    private List<IClueItem> mItems = new List<IClueItem>();
    public event EventHandler<ClueEventArgs> ItemAdded;
    public event EventHandler<ClueEventArgs> ItemObserved;
    public event EventHandler<ClueEventArgs> ItemsCollected;
    public void AddItem(IClueItem item)
    {
        if (mItems.Count < SLOTS)
        {
            Collider collider = (item as MonoBehaviour).GetComponent<Collider>();
            if (collider.enabled)
            {
                collider.enabled = false;
                mItems.Add(item);
                item.OnPickUp();

                if(ItemAdded != null)
                {
                    ItemAdded(this, new ClueEventArgs(item));
                }
            }
        }
    }

    public void ObserveItem(IClueItem item)
    {
        if (ItemObserved != null)
        {
            ItemObserved(this, new ClueEventArgs(item));
        }
    }
    public void AllItemsCollected(IClueItem item)
    {
        if (mItems.Count == SLOTS)
        {
            ItemsCollected(this, new ClueEventArgs(item));
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
