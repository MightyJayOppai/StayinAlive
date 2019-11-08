using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public ClueLog clueLog;
    public static bool clueLogIsDisplayed = false;
    public GameObject clueLogUI;
    void Start()
    {
        clueLog.ItemAdded += ClueLogScript_ItemAdded;
    }

    private void ClueLogScript_ItemAdded(object sender, ClueEventArgs e)
    {
        Transform clueLogPanel = transform.Find("ClueLogPanel");
        foreach(Transform slot in clueLogPanel)
        {
            Transform imageTransform = slot.GetChild(0).GetChild(0);
            Image image = imageTransform.GetComponent<Image>();
            ItemDragHandler itemDragHandler = imageTransform.GetComponent<ItemDragHandler>();

            //Found an empty slot
            if (!image.enabled)
            {
                image.enabled = true;
                image.sprite = e.Item.Image;

                // Store a reference to the item
                itemDragHandler.Item = e.Item;
                break;
            }
        }
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if (clueLogIsDisplayed)
            {
                Hide();
            }
            else
            {
                Display();
            }
        }
    }
    public void Hide()
    {
        clueLogUI.SetActive(false);
        clueLogIsDisplayed = false;
    }
    public void Display()
    {
        clueLogUI.SetActive(true);
        clueLogIsDisplayed = true;
    }
}
