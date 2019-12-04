using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseCamManager : MonoBehaviour
{
    [SerializeField] private GameObject hCamA1;
    [SerializeField] private GameObject hCamA2;
    [SerializeField] private GameObject hCamB1;
    [SerializeField] private GameObject hCamB2;
    [SerializeField] private GameObject hCamC1;
    [SerializeField] private GameObject hCamC2;
    [SerializeField] private GameObject hCamC3;
    [SerializeField] private GameObject hCamD1;
    
    public delegate void SendEvents();
    public static event SendEvents onPlayerStop;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AreaA1")
        {
            hCamA1.SetActive(true);
            hCamA2.SetActive(false);
            hCamB1.SetActive(false);
            hCamB2.SetActive(false);
            Debug.Log("Cam Switched to hCamA1");
        }

        if (other.tag == "AreaA2")
        {
            hCamA2.SetActive(true);
            hCamA1.SetActive(false);
            hCamB1.SetActive(false);
            hCamB2.SetActive(false);
            Debug.Log("Cam Switched to hCamA2");
        }

        if (other.tag == "AreaB1")
        {
            hCamB1.SetActive(true);
            hCamB2.SetActive(false);
            hCamA2.SetActive(false);
            hCamA1.SetActive(false);
            Debug.Log("Cam Switched to hCamB1");
        }

        if (other.tag == "AreaB2")
        {
            hCamB2.SetActive(true);
            hCamB1.SetActive(false);
            hCamA2.SetActive(false);
            hCamA1.SetActive(false);
            Debug.Log("Cam Switched to hCamB2");
        }

        if (other.tag == "AreaC1")
        {
            hCamC1.SetActive(true);
            hCamC2.SetActive(false);
            hCamB1.SetActive(false);
            hCamB2.SetActive(false);
            Debug.Log("Cam Switched to hCamC1");
        }

        if (other.tag == "AreaC2")
        {
            hCamC2.SetActive(true);
            hCamC1.SetActive(false);
            hCamB1.SetActive(false);
            hCamB2.SetActive(false);
            Debug.Log("Cam Switched to hCamC2");
        }

        if (other.tag == "AreaC3")
        {
            hCamC3.SetActive(true);
            hCamB1.SetActive(false);
            hCamB2.SetActive(false);
            hCamC2.SetActive(false);
            hCamC1.SetActive(false);
            hCamD1.SetActive(false);
            Debug.Log("Cam Switched to hCamC3");
        }

        if (other.tag == "AreaD1")
        {
            hCamD1.SetActive(true);
            hCamC3.SetActive(false);
            Debug.Log("Cam Switched to hCamD1");
        }
    }
}
