using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueObserver : MonoBehaviour
{
    public ClueLog clueLog;
    public GameObject observationCam;
    public GameObject mainCam;
    public float speed;
    public HUD hud;
    void Start()
    {
        clueLog.ItemObserved += ClueLog_ItemObserved;
    }
    public void ClueLog_ItemObserved(object sender, ClueEventArgs e)
    {
        //Get ClueLog item from the ClueEventArgs
        IClueItem item = e.Item;

        //Do something with the item
        //This case rotate it  
        hud.clueLogUI.SetActive(false);
        observationCam.SetActive(true);
        mainCam.SetActive(false);
        Time.timeScale = 0f;
        
    }
    void Update()
    {
        CloseObserveCam();
    }

    public void CloseObserveCam()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Time.timeScale = 1f;
            observationCam.SetActive(false);
            mainCam.SetActive(true);
            hud.clueLogUI.SetActive(true);
        }
    }
}
