using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue1 : MonoBehaviour, IClueItem
{
    public string Name
    {
        get
        {
            return "Clue1";
        }
    }

    public Sprite _Image = null;
    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }
    public void OnPickUp()
    {
        gameObject.SetActive(false);
    }
}
