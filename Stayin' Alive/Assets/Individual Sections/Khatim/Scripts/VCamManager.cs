using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VCamManager : MonoBehaviour
{
    [SerializeField] private GameObject vCamA1;
    [SerializeField] private GameObject vCamA2;
    [SerializeField] private GameObject vCamB1;
    [SerializeField] private GameObject vCamB3;
    [SerializeField] private GameObject vCamC1;
    [SerializeField] private GameObject vCamC2Pan;
    [SerializeField] private GameObject vCamC3;
    [SerializeField] private GameObject vCamD3;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AreaA1")
        {
            vCamA1.SetActive(true);
            vCamA2.SetActive(false);
            Debug.Log("Cam Switched to VCamA1");
        }

        if (other.tag == "AreaA2")
        {
            vCamA2.SetActive(true);
            vCamA1.SetActive(false);
            vCamB1.SetActive(false);
            vCamC1.SetActive(false);
            Debug.Log("Cam Switched to VCamA2");
        }

        if (other.tag == "AreaB1")
        {
            vCamB1.SetActive(true);
            vCamA2.SetActive(false);
            vCamB3.SetActive(false);
            Debug.Log("Cam Switched to VCamB1");
        }

        if (other.tag == "AreaB2")
        {
            vCamB3.SetActive(true);
            vCamB1.SetActive(false);
            Debug.Log("Cam Switched to VCamB3");
        }

        if (other.tag == "AreaC1")
        {
            vCamC1.SetActive(true);
            vCamA2.SetActive(false);
            Debug.Log("Cam Switched to VCamC1");
        }

        if (other.tag == "AreaC2")
        {
            vCamC2Pan.SetActive(true);
            vCamC1.SetActive(false);
            vCamC3.SetActive(false);
            Debug.Log("Cam Switched to VCamC2");
        }

        if (other.tag == "AreaC3")
        {
            vCamC3.SetActive(true);
            vCamC2Pan.SetActive(false);
            vCamD3.SetActive(false);
            Debug.Log("Cam Switched to VCamC3");
        }

        if (other.tag == "AreaD3")
        {
            vCamD3.SetActive(true);
            vCamC2Pan.SetActive(false);
            Debug.Log("Cam Switched to VCamD3");
        }
    }
}