using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject clueLogPanel;
    public GameObject[] clueIcons;
    [SerializeField] private Collider playerCol;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        GameObject i;

        if (playerCol != null && Input.GetKey(KeyCode.E) && other.tag == "Clue1")
        {
            Debug.Log("Player is there");
            Destroy(other.gameObject);
            i = Instantiate(clueIcons[0]);
            i.transform.SetParent (clueLogPanel.transform);
        }

        else if (playerCol != null && Input.GetKey(KeyCode.E) && other.tag == "Clue2")
        {
            Destroy(other.gameObject);
            i = Instantiate(clueIcons[1]);
            i.transform.SetParent (clueLogPanel.transform);
        }

        else if (playerCol != null && Input.GetKey(KeyCode.E) && other.tag == "Clue3")
        {
            Destroy(other.gameObject);
            i = Instantiate(clueIcons[2]);
            i.transform.SetParent (clueLogPanel.transform);
        }

        else if (playerCol != null && Input.GetKey(KeyCode.E) && other.tag == "Clue4")
        {
            Destroy(other.gameObject);
            i = Instantiate(clueIcons[3]);
            i.transform.SetParent (clueLogPanel.transform);
        }
    }
}
