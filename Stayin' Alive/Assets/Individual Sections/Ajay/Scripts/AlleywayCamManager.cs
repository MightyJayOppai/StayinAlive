using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlleywayCamManager : MonoBehaviour
{
    [SerializeField] private GameObject vCamA1;
    [SerializeField] private GameObject vCamB1;
    [SerializeField] private GameObject vCamB2;
    [SerializeField] private GameObject vCamC1;
    [SerializeField] private GameObject vCamC2Pan;
    [SerializeField] private GameObject vCamC3;
    [SerializeField] private GameObject vCamD1;
    [SerializeField] private GameObject vCamD2;
    [SerializeField] private GameObject vCamD3;
    [SerializeField] private GameObject vCamD4;

    public delegate void SendEvents();
    public static event SendEvents onPlayerStop;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AreaA1")
        {
            vCamA1.SetActive(true);
            vCamB1.SetActive(false);
            vCamC1.SetActive(false);
            Debug.Log("Cam Switched to VCamA1");
        }

        if (other.tag == "AreaB1")
        {
            vCamB1.SetActive(true);
            vCamA1.SetActive(false);
            vCamB2.SetActive(false);
            vCamC1.SetActive(false);
            Debug.Log("Cam Switched to VCamB1");
        }

        if (other.tag == "AreaB2")
        {
            vCamB2.SetActive(true);
            vCamB1.SetActive(false);
            vCamC1.SetActive(false);
            vCamA1.SetActive(false);
            Debug.Log("Cam Switched to VCamB2");
        }

        if (other.tag == "AreaC1")
        {
            vCamC1.SetActive(true);
            vCamC2Pan.SetActive(false);
            vCamC3.SetActive(false);
            vCamA1.SetActive(false);
            vCamB1.SetActive(false);
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
            vCamD1.SetActive(false);
            Debug.Log("Cam Switched to VCamC3");
        }

        if (other.tag == "AreaD1")
        {
            vCamD1.SetActive(true);
            vCamC2Pan.SetActive(false);
            vCamC3.SetActive(false);
            Debug.Log("Cam Switched to VCamD1");
        }
        if (other.tag == "AreaD2")
        {
            vCamD2.SetActive(true);
            vCamD1.SetActive(false);
            vCamD3.SetActive(false);
            vCamD4.SetActive(false);
            vCamC2Pan.SetActive(false);
            Debug.Log("Cam Switched to VCamD2");
        }
        if (other.tag == "AreaD3")
        {
            vCamD3.SetActive(true);
            vCamD1.SetActive(false);
            vCamD2.SetActive(false);
            vCamD4.SetActive(false);
            Debug.Log("Cam Switched to VCamD3");
        }
        if (other.tag == "AreaD4")
        {
            vCamD4.SetActive(true);
            vCamD1.SetActive(false);
            vCamD2.SetActive(false);
            vCamD3.SetActive(false);
            Debug.Log("Cam Switched to VCamD4");
        }
    }

    /*void OnTriggerExit(Collider other)
    {
        // if (other.tag == "AreaA1")
        // {
        //     if (onPlayerStop != null)
        //         onPlayerStop();
        // }

        if (other.tag == "AreaA2")
        {
            if (onPlayerStop != null)
                onPlayerStop();
        }

        if (other.tag == "AreaB1")
        {
            if (onPlayerStop != null)
                onPlayerStop();
        }

        if (other.tag == "AreaB2")
        {
            if (onPlayerStop != null)
                onPlayerStop();
        }
    }*/
}