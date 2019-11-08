using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IClueItem 
{
    string Name { get; }
    Sprite Image { get; }
    
    void OnPickUp();
    void OnUse();
}

public class ClueEventArgs : EventArgs
{
    public ClueEventArgs(IClueItem item)
    {
        Item = item;
    }
    public IClueItem Item;
}
