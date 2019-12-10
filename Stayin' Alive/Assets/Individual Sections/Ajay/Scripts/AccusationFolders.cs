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
    [SerializeField] private Collider playerCol;
    public MapSceneManager mapScene;
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
                if (mapScene.isAlleyway)
                {
                    accAlleywayScreen.SetActive(true);
                    accParkScreen.SetActive(false);
                    accDocksScreen.SetActive(false);
                }
                
                if (mapScene.isPark)
                {
                    accParkScreen.SetActive(true);
                    accAlleywayScreen.SetActive(false);
                    accDocksScreen.SetActive(false);
                }

                if (mapScene.isDocks)
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
}
