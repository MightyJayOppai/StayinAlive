using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObservationController : MonoBehaviour
{
    public GameObject[] observeIcons;
    public GameObject observationCamera;
    public GameObject clueSpawner;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void ActivateClue()
    {
        Instantiate(observeIcons[0], clueSpawner.transform.position, clueSpawner.transform.rotation);
    }
}
