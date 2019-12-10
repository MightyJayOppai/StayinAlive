using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ClueLog : MonoBehaviour
{
    private const int SLOTS = 4;
    private List<IClueItem> mItems = new List<IClueItem>();
    public event EventHandler<ClueEventArgs> ItemAdded;
    public event EventHandler<ClueEventArgs> ItemObserved;
    public MapSceneManager mapScene;
    public AccusationFolders accusation;

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

                if (ItemAdded != null)
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
    void Start()
    {
        
    }

    void Update()
    {
        if (mItems.Count == SLOTS && Application.loadedLevelName == "AlleywayScene")
        {
            mapScene.MoveToOffice();
            mapScene.CaseFromAlleyway();
            DontDestroyOnLoad(mapScene);
        }

        if (mItems.Count == SLOTS && Application.loadedLevelName == "ParkScene")
        {
            mapScene.MoveToOffice();
            mapScene.CaseFromPark();
            DontDestroyOnLoad(mapScene);
        }

        if (mItems.Count == SLOTS && Application.loadedLevelName == "DocksScene")
        {
            mapScene.MoveToOffice();
            mapScene.CaseFromDocks();
            DontDestroyOnLoad(mapScene);
        }
    }
}
