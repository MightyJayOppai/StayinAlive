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
        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
    }
    public void MoveToHouse()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        //Debug.Log("Loading Menu");
    }
    public void MoveToOffice()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    public void MoveToDocks()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
    }
    public void QuitGame()
    {
        Application.Quit();
        //Debug.Log("Im'ma Head out");
    }
}
