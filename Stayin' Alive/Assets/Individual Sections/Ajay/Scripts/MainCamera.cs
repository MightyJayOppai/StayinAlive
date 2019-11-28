using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    void Start()
    {
        CamManager.mainCam.SwitchCamera();
    }

    void Update()
    {
        
    }
}
