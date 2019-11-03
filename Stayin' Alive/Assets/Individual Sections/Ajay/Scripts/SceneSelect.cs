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
        UnityEngine.SceneManagement.SceneManager.LoadScene(4);
    }
    public void MoveToBasement()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
    public void LoadMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        //Debug.Log("Loading Menu");
    }
    public void MoveToOffice()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
        //Debug.Log("Im'ma Head out");
    }
}
