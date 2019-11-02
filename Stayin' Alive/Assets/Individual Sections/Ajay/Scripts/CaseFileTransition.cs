using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaseFileTransition : MonoBehaviour
{
    public GameObject sceneTransitionScreen;
    public Collider col;    
    public GameObject transitionText;
    void Start()
    {
        sceneTransitionScreen.SetActive(false);
        transitionText.SetActive(false);
    }

    
    void Update()
    {
        if(col!= null && Input.GetKeyDown(KeyCode.E))
        {
            sceneTransitionScreen.SetActive(!sceneTransitionScreen.activeSelf);
            if (sceneTransitionScreen.activeSelf)
            {
                //GetComponent<MapSceneManager>().TransitionToAlleyway();
                UnityEngine.SceneManagement.SceneManager.LoadScene(2);
                Debug.Log("Go to the Alleyway");
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        //To display the Screen once the player enters the collider
        if (other.tag == "Player")
        {
            col = other;
            sceneTransitionScreen.SetActive(true);
            transitionText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        //To remove the Screen once the player moves away from the collider
        if (other.tag == "Player")
        {
            col = null;
            sceneTransitionScreen.SetActive(false);
            transitionText.SetActive(false);
        }
    }
}
