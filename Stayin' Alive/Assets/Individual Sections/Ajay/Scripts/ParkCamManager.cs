using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkCamManager : MonoBehaviour
{
    [SerializeField] private GameObject pCamA1;
    [SerializeField] private GameObject pCamA2;
    [SerializeField] private GameObject pCamA3;
    [SerializeField] private GameObject pCamB1;
    [SerializeField] private GameObject pCamB2;
    [SerializeField] private GameObject pCamB3;
    [SerializeField] private GameObject pCamC1;
    [SerializeField] private GameObject pCamC2;
    [SerializeField] private GameObject pCamC3;
    [SerializeField] private GameObject pCamD1;
    [SerializeField] private GameObject pCamD2;
    [SerializeField] private GameObject pCamD3;
    [SerializeField] private GameObject pCamD4Pan;
    [SerializeField] private GameObject pCamD5;
    [SerializeField] private GameObject pCamE2;
    [SerializeField] private GameObject pCamF1;
    [SerializeField] private GameObject pCamF2;
    [SerializeField] private GameObject pCamF3;
    [SerializeField] private GameObject pCamF4;
    [SerializeField] private GameObject pCamF5;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AreaA1")
        {
            pCamA1.SetActive(true);
            pCamA2.SetActive(false);
            pCamA3.SetActive(false);
            Debug.Log("Cam Switched to pCamA1");
        }

        if (other.tag == "AreaA2")
        {
            pCamA2.SetActive(true);
            pCamA1.SetActive(false);
            pCamA3.SetActive(false);
            Debug.Log("Cam Switched to pCamA2");
        }

        if (other.tag == "AreaA3")
        {
            pCamA3.SetActive(true);
            pCamA1.SetActive(false);
            pCamA2.SetActive(false);
            Debug.Log("Cam Switched to pCamA3");
        }

        if (other.tag == "AreaB1")
        {
            pCamB1.SetActive(true);
            pCamB2.SetActive(false);
            pCamB3.SetActive(false);
            Debug.Log("Cam Switched to pCamB1");
        }

        if (other.tag == "AreaB2")
        {
            pCamB2.SetActive(true);
            pCamB1.SetActive(false);
            pCamB3.SetActive(false);
            Debug.Log("Cam Switched to pCamB2");
        }

        if (other.tag == "AreaB3")
        {
            pCamB3.SetActive(true);
            pCamB1.SetActive(false);
            pCamB2.SetActive(false);
            Debug.Log("Cam Switched to pCamB3");
        }

        if (other.tag == "AreaC1")
        {
            pCamC1.SetActive(true);
            pCamC2.SetActive(false);
            pCamC3.SetActive(false);
            Debug.Log("Cam Switched to pCamC1");
        }

        if (other.tag == "AreaC2")
        {
            pCamC2.SetActive(true);
            pCamC1.SetActive(false);
            pCamC3.SetActive(false);
            Debug.Log("Cam Switched to pCamC2");
        }
        
        if (other.tag == "AreaC3")
        {
            pCamC3.SetActive(true);
            pCamC1.SetActive(false);
            pCamC2.SetActive(false);
            Debug.Log("Cam Switched to pCamC3");
        }
        
        if (other.tag == "AreaD1")
        {
            pCamD1.SetActive(true);
            pCamD2.SetActive(false);
            pCamD3.SetActive(false);
            Debug.Log("Cam Switched to pCamD1");
        }

        if (other.tag == "AreaD2")
        {
            pCamD2.SetActive(true);
            pCamD1.SetActive(false);
            pCamD3.SetActive(false);
            Debug.Log("Cam Switched to pCamD2");
        }
        
        if (other.tag == "AreaD3")
        {
            pCamD3.SetActive(true);
            pCamD1.SetActive(false);
            pCamD2.SetActive(false);
            Debug.Log("Cam Switched to pCamD3");
        }

        if (other.tag == "AreaD4")
        {
            pCamD4Pan.SetActive(true);
            pCamD1.SetActive(false);
            pCamD2.SetActive(false);
            pCamD3.SetActive(false);
            Debug.Log("Cam Switched to pCamD4Pan");
        }


        if (other.tag == "AreaE2")
        {
            pCamE2.SetActive(true);
            pCamA1.SetActive(false);
            Debug.Log("Cam Switched to pCamE2");
        }

        if (other.tag == "AreaF1")
        {
            pCamF1.SetActive(true);
            pCamF2.SetActive(false);
            pCamF3.SetActive(false);
            Debug.Log("Cam Switched to pCamF1");
        }

        if (other.tag == "AreaF2")
        {
            pCamF2.SetActive(true);
            pCamF1.SetActive(false);
            pCamF3.SetActive(false);
            Debug.Log("Cam Switched to pCamF2");
        }

        if (other.tag == "AreaF3")
        {
            pCamF3.SetActive(true);
            pCamF1.SetActive(false);
            pCamF2.SetActive(false);
            Debug.Log("Cam Switched to pCamF3");
        }

        if (other.tag == "AreaF4")
        {
            pCamF4.SetActive(true);
            pCamF2.SetActive(false);
            pCamF3.SetActive(false);
            Debug.Log("Cam Switched to pCamF4");
        }

        if (other.tag == "AreaF5")
        {
            pCamF5.SetActive(true);
            pCamF3.SetActive(false);
            pCamF4.SetActive(false);
            Debug.Log("Cam Switched to pCamF5");
        }
    }
}
