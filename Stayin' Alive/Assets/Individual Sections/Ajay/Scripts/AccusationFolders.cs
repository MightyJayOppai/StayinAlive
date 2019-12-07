using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccusationFolders : MonoBehaviour
{
    public GameObject accFilesBG;
    public GameObject accFilesText;
    public GameObject accAlleywayScreen;
    public GameObject accParkScreen;
    public GameObject accDocksScreen;
    public GameObject fileAlleyway;
    public GameObject filePark;
    public GameObject fileDocks;
    public bool isAlleyway;
    public bool isPark;
    public bool isDocks;
    [SerializeField] private Collider playerCol;
    void Start()
    {
        
    }

    void Update()
    {
        if(playerCol != null && Input.GetKeyDown(KeyCode.E))
        {
            if (accFilesBG.activeSelf)
            {
                accFilesBG.SetActive(!accFilesBG.activeSelf);
                //Use bool as if
                if (isAlleyway == true)
                {
                    accAlleywayScreen.SetActive(true);
                    accParkScreen.SetActive(false);
                    accDocksScreen.SetActive(false);
                }
                
                if (isPark == true)
                {
                    accParkScreen.SetActive(true);
                    accAlleywayScreen.SetActive(false);
                    accDocksScreen.SetActive(false);
                }

                if (isDocks == true)
                {
                    accDocksScreen.SetActive(true);
                    accParkScreen.SetActive(false);
                    accAlleywayScreen.SetActive(false);
                }
                //GetComponent<MapSceneManager>().TransitionToAlleyway();
                //UnityEngine.SceneManagement.SceneManager.LoadScene(2);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Enable BG for Case files
        // if condition for the the Case function
    }

    void OnTriggerExit(Collider other) 
    {
        
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
