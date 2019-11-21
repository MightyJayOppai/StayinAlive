using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{
    private static CamManager _instance;
    public static  CamManager mainCam {get {return _instance;} }

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            _instance = new CamManager();
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void SwitchCamera()
    {
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
