using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccusationFolders : MonoBehaviour
{
    public GameObject accFilesBG;
    public GameObject accTextBG;
    public GameObject accFilesText;
    [SerializeField] private Collider playerCol;
    void Start()
    {
        
    }

    private void Update() 
    {
        if(playerCol != null && Input.GetKeyDown(KeyCode.E))
        {
            if (accTextBG.activeSelf)
            {
                accTextBG.SetActive(false);
                accFilesBG.SetActive(true);
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
            accTextBG.SetActive(true);
            accFilesText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        //To remove the Screen once the player moves away from the collider
        if (other.tag == "Player")
        {
            playerCol = null;
            accTextBG.SetActive(false);
            accFilesText.SetActive(false);
            accFilesBG.SetActive(false);
        }
    }


}
