using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue2 : MonoBehaviour, IClueItem
{
    public string Name
    {
        get
        {
            return "Clue2";
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
    public void OnPickUp()
    {
        gameObject.SetActive(false);
    }
}
