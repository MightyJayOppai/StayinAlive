using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObserveClues : MonoBehaviour
{
    private GameObject observationController;
    public  GameObject observedClue;
    void Start()
    {

    }

    void Update()
    {
        
    }
    
    public void FindOCC()
    {
        observationController = GameObject.FindWithTag("ClueObservation");
    }

}
