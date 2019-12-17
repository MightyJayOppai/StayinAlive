using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilesManager : MonoBehaviour
{
    public GameObject alleywayTransition;
    public GameObject parkTransition;
    public GameObject docksTransition;
    public GameObject fileAlleyway;
    public GameObject filePark;
    public GameObject fileDocks;
    public GameObject accAlleywayScreen;
    public GameObject accParkScreen;
    public GameObject accDocksScreen;
    public MapSceneManager mapScene;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (mapScene.isAlleyway == true)
        {
            alleywayTransition.SetActive(true);
            parkTransition.SetActive(false);
            docksTransition.SetActive(false);
            fileAlleyway.SetActive(true);
            filePark.SetActive(false);
            fileDocks.SetActive(false);
            accAlleywayScreen.SetActive(true);
            accParkScreen.SetActive(false);
            accDocksScreen.SetActive(false);
        }

        if (mapScene.isPark == true)
        {
            parkTransition.SetActive(true);
            alleywayTransition.SetActive(false);
            docksTransition.SetActive(false);
            filePark.SetActive(true);
            fileAlleyway.SetActive(false);
            fileDocks.SetActive(false);
            accParkScreen.SetActive(true);
            accAlleywayScreen.SetActive(false);
            accDocksScreen.SetActive(false);
        }

        if (mapScene.isDocks == true)
        {
            docksTransition.SetActive(true);
            alleywayTransition.SetActive(false);
            parkTransition.SetActive(false);
            fileDocks.SetActive(true);
            fileAlleyway.SetActive(false);
            filePark.SetActive(false);
            accDocksScreen.SetActive(true);
            accParkScreen.SetActive(false);
            accAlleywayScreen.SetActive(false);
        }
    }
}
