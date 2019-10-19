using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{
    [Header("Player Collider")]
    [SerializeField] private Collider playerCol;
    public delegate void SendEvents(GameObject obj);
    public static event SendEvents onDetectiveUIEnable;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnEnable()
    {
        if(playerCol != null && Input.GetKey(KeyCode.E) && playerCol.tag == "Clue")
        {
            if(onDetectiveUIEnable != null)
            {
                onDetectiveUIEnable(playerCol.gameObject);
                Debug.Log("Object Picked Up");
            }
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Clue")
        {
            playerCol= other;
            Debug.Log("Examining Object");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Clue")
        {
            playerCol= null;
            Debug.Log("Leaving Object");
        }
    }
}
