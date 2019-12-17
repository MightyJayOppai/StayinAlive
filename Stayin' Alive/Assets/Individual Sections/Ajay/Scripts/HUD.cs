using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public static bool clueLogIsDisplayed = false;
    public GameObject clueLogUI;
    public GameObject MessagePanel;
    
    void Start()
    {
        
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
    public void OpenMessagePanel(string text)
    {
        MessagePanel.SetActive(true);
    }
    public void CloseMessagePanel()
    {
        MessagePanel.SetActive(false);
    }
}
