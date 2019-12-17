using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MapSceneManager : MonoBehaviour
{
    public bool isAlleyway;
    public bool isPark;
    public bool isDocks;
    public GameObject loadingText;
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
        loadingText.SetActive(true);
    }
    public void MoveToDocks()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
    }
    public void MoveToPark()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(7);
    }
    public void QuitGame()
    {
        Application.Quit();
        //Debug.Log("Im'ma Head out");
    }
}
