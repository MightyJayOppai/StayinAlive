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

        if (other.tag == "Clue1")
        {
            Destroy(other.gameObject);
            i = Instantiate(clueIcons[0]);
            i.transform.SetParent (clueLogPanel.transform);
        }

        else if (other.tag == "Clue2")
        {
            i = Instantiate(clueIcons[1]);
            i.transform.SetParent (clueLogPanel.transform);
        }

        else if (other.tag == "Clue3")
        {
            i = Instantiate(clueIcons[2]);
            i.transform.SetParent (clueLogPanel.transform);
        }

        else if (other.tag == "Clue4")
        {
            i = Instantiate(clueIcons[3]);
            i.transform.SetParent (clueLogPanel.transform);
        }
    }
}
