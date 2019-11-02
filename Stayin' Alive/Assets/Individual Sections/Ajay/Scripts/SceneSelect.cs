using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void MoveToAlleyway()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }
    public void MoveToBasement()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
