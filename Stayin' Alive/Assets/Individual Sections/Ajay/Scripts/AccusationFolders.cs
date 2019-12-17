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

    void Update()
    {
        if(playerCol != null && Input.GetKeyDown(KeyCode.E))
        {
            if (accTextBG.activeSelf)
            {
                accTextBG.SetActive(!accTextBG.activeSelf);
                accFilesBG.SetActive(true);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerCol = other;
            accTextBG.SetActive(true);
            accFilesText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Player")
        {
            playerCol = null;
            accFilesBG.SetActive(false);
            accFilesText.SetActive(false);
            accTextBG.SetActive(false);
        }
    }
}
