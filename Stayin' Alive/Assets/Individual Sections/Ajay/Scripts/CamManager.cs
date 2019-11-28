using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{
<<<<<<< HEAD
    private static CamManager _instance;
    public static  CamManager mainCam {get {return _instance;} }

=======
    private static CamManager instance = null;
    public GameObject mainCam;
>>>>>>> fe8a0e290f3316054f3efdb3da0fa45a9767b726
    private void Awake()
    {
        if (instance == null)
        {
<<<<<<< HEAD
            _instance = new CamManager();
=======
            instance = this;
>>>>>>> fe8a0e290f3316054f3efdb3da0fa45a9767b726
        }
        else if (instance != this)
        {
<<<<<<< HEAD
            _instance = this;
            DontDestroyOnLoad(gameObject);
=======
            Destroy(gameObject);
>>>>>>> fe8a0e290f3316054f3efdb3da0fa45a9767b726
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
