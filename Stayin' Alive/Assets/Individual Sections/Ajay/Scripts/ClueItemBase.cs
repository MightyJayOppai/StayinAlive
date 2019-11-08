using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueItemBase : MonoBehaviour, IClueItem 
{
    public virtual string Name
    {
        get
        {
            return "_base clue_";
        }
    }
    public Sprite _Image;
    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }
    public virtual void OnPickUp()
    {
        gameObject.SetActive(false);
    }
    public virtual void OnUse()
    {
        
    }
}
