using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MapSceneManager : MonoBehaviour
{
    public GameObject fileAlleyway;
    public GameObject filePark;
    public GameObject fileDocks;
    public bool isAlleyway;
    public bool isPark;
    public bool isDocks;
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
    public void MoveToPark()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(7);
    }
    public void QuitGame()
    {
        Application.Quit();
        //Debug.Log("Im'ma Head out");
    }

    public void CaseFromAlleyway()
    {
        isAlleyway = true;
        fileAlleyway.SetActive(true);
        filePark.SetActive(false);
        fileDocks.SetActive(false);
    }

    public void CaseFromPark()
    {
        isPark = true;
        filePark.SetActive(true);
        fileAlleyway.SetActive(false);
        fileDocks.SetActive(false);
    }
    public void CaseFromDocks()
    {
        isDocks = true;
        fileDocks.SetActive(true);
        fileAlleyway.SetActive(false);
        filePark.SetActive(false);
    }
}
