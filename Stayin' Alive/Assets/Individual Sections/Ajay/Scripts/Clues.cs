using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clues : MonoBehaviour
{
    [SerializeField] private Text pickUpText;
    private bool pickUpAllowed;
    public GameObject clueLogPanel;
    public GameObject[] clueIcons;
    void Start()
    {
        pickUpText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Player in Range");
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Player has left Range");
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        GameObject i;

        if(gameObject.tag == "Clue1")
        {
            gameObject.SetActive(false);
            i = Instantiate(clueIcons[0]);
            i.transform.SetParent (clueLogPanel.transform);
        }
        else if (gameObject.tag == "Clue2")
        {
            gameObject.SetActive(false);
            i = Instantiate(clueIcons[1]);
            i.transform.SetParent (clueLogPanel.transform);
        }

        else if (gameObject.tag == "Clue3")
        {
            gameObject.SetActive(false);
            i = Instantiate(clueIcons[2]);
            i.transform.SetParent (clueLogPanel.transform);
        }

        else if (gameObject.tag == "Clue4")
        {
            gameObject.SetActive(false);
            i = Instantiate(clueIcons[3]);
            i.transform.SetParent (clueLogPanel.transform);
        }
    }
}

