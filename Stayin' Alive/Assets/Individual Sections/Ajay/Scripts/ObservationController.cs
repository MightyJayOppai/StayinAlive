using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObservationController : MonoBehaviour
{
    public GameObject[] observeIcons;
    public GameObject observationCamera;
    public GameObject clueSpawner;    
    public GameObject clueLogPanel;
    public bool isObserved;
    public GameObject obj;
    void Start()
    {
        
    }

    void Update()
    {
        if (isObserved && Input.GetKey(KeyCode.Q))
        {
            CloseObserveCam();
        }
    }

    public void ActivateClue(GameObject clue)
    {
        obj=Instantiate(clue, clueSpawner.transform.position, clueSpawner.transform.rotation);
        isObserved = true;
        OpenObserveCam();      
    }
    
    public void OpenObserveCam()
    {
        Time.timeScale = 0f;
        observationCamera.SetActive(true);
        clueLogPanel.SetActive(false);
    }
    public void CloseObserveCam()
    {
        Time.timeScale = 1f;
        observationCamera.SetActive(false);
        Destroy(obj);
    }
}
