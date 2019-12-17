using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaseFileTransition : MonoBehaviour
{
    public GameObject transitionTextBG;
    public GameObject transitionText;
    public GameObject sceneTransitionScreen;
    [SerializeField] private Collider playerCol;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(playerCol != null && Input.GetKeyDown(KeyCode.E))
        {
            if (transitionTextBG.activeSelf)
            {
                transitionTextBG.SetActive(!transitionTextBG.activeSelf);
                sceneTransitionScreen.SetActive(true);
                //GetComponent<MapSceneManager>().TransitionToAlleyway();
                //UnityEngine.SceneManagement.SceneManager.LoadScene(2);
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        //To display the Screen once the player enters the collider
        if (other.tag == "Player")
        {
            playerCol = other;
            transitionTextBG.SetActive(true);
            transitionText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        //To remove the Screen once the player moves away from the collider
        if (other.tag == "Player")
        {
            playerCol = null;
            transitionTextBG.SetActive(false);
            transitionText.SetActive(false);
            sceneTransitionScreen.SetActive(false);
        }
    }
}
