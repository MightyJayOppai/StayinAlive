using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public ClueLog clueLog;
    void Start()
    {
        clueLog.ItemAdded += ClueLogScript_ItemAdded;
    }

    private void ClueLogScript_ItemAdded(object sender, ClueEventArgs e)
    {
        Transform clueLogPanel = transform.Find("ClueLogPanel");
        foreach(Transform slot in clueLogPanel)
        {
            Image image = slot.GetChild(0).GetComponent<Image>();

            if (!image.enabled)
            {
                image.enabled = true;
                image.sprite = e.Item.Image;

                break;
            }
        }
    }
    void Update()
    {
        
    }
}
