using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{
    private static CamManager _instance;
    public static  CamManager mainCam {get {return _instance;} }

    private static CamManager instance = null;
    public GameObject mainCam;
    private void Awake()
    {
        if (instance == null)
        {
            _instance = new CamManager();
            instance = this;
        }
        else if (instance != this)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
            Destroy(gameObject);
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
