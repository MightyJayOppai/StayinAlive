using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeCamManager : MonoBehaviour
{
    [SerializeField] private GameObject oCamA1;
    [SerializeField] private GameObject oCamA2;
    [SerializeField] private GameObject oCamB1;
    [SerializeField] private GameObject oCamB2;
    [SerializeField] private GameObject oCamB3;
    [SerializeField] private GameObject oCamB4Pan;
    [SerializeField] private GameObject oCamC1;
    [SerializeField] private GameObject oCamD1;
    [SerializeField] private GameObject oCamD2;

    public delegate void SendEvents();
    public static event SendEvents onPlayerStop;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AreaA1")
        {
            oCamA1.SetActive(true);
            oCamA2.SetActive(false);
            oCamB1.SetActive(false);
            oCamB2.SetActive(false);
            Debug.Log("Cam Switched to oCamA1");
        }

        if (other.tag == "AreaA2")
        {
            oCamA2.SetActive(true);
            oCamA1.SetActive(false);
            oCamB1.SetActive(false);
            oCamC1.SetActive(false);
            Debug.Log("Cam Switched to oCamA2");
        }

        if (other.tag == "AreaB1")
        {
            oCamB1.SetActive(true);
            oCamB2.SetActive(false);
            oCamB3.SetActive(false);
            oCamB4Pan.SetActive(false);
            oCamA2.SetActive(false);
            oCamA1.SetActive(false);
            Debug.Log("Cam Switched to oCamB1");
        }

        if (other.tag == "AreaB2")
        {
            oCamB2.SetActive(true);
            oCamB1.SetActive(false);
            oCamB3.SetActive(false);
            oCamB4Pan.SetActive(false);
            oCamC1.SetActive(false);
            Debug.Log("Cam Switched to oCamB2");
        }

        if (other.tag == "AreaB3")
        {
            oCamB3.SetActive(true);
            oCamB1.SetActive(false);
            oCamB2.SetActive(false);
            Debug.Log("Cam Switched to oCamB3");
        }

        if (other.tag == "AreaB4Pan")
        {
            oCamB4Pan.SetActive(true);
            oCamB1.SetActive(false);
            oCamB2.SetActive(false);
            oCamB3.SetActive(false);
            oCamC1.SetActive(false);
            Debug.Log("Cam Switched to oCamB4Pan");
        }

        if (other.tag == "AreaC1")
        {
            oCamC1.SetActive(true);
            oCamB1.SetActive(false);
            oCamB2.SetActive(false);
            oCamB3.SetActive(false);
            oCamB4Pan.SetActive(false);
            Debug.Log("Cam Switched to oCamC1");
        }

        if (other.tag == "AreaD1")
        {
            oCamD1.SetActive(true);
            oCamA1.SetActive(false);
            oCamA2.SetActive(false);
            oCamB1.SetActive(false);
            oCamB2.SetActive(false);
            oCamB3.SetActive(false);
            oCamD2.SetActive(false);
            Debug.Log("Cam Switched to oCamD1");
        }
        if (other.tag == "AreaD2")
        {
            oCamD2.SetActive(true);
            oCamA1.SetActive(false);
            oCamA2.SetActive(false);
            oCamB1.SetActive(false);
            oCamB2.SetActive(false);
            oCamB3.SetActive(false);
            oCamD1.SetActive(false);
            Debug.Log("Cam Switched to oCamD2");
        }
    }

    void OnTriggerExit(Collider other)
    {
        // if (other.tag == "AreaA1")
        // {
        //     if (onPlayerStop != null)
        //         onPlayerStop();
        // }

        if (other.tag == "AreaA1")
        {
            if (onPlayerStop != null)
                onPlayerStop();
        }

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

        if (other.tag == "AreaB3")
        {
            if (onPlayerStop != null)
                onPlayerStop();
        }

        if (other.tag == "AreaB4Pan")
        {
            if (onPlayerStop != null)
                onPlayerStop();
        }

        if (other.tag == "AreaC1")
        {
            if (onPlayerStop != null)
                onPlayerStop();
        }

        if (other.tag == "AreaC2")
        {
            if (onPlayerStop != null)
                onPlayerStop();
        }

        if (other.tag == "AreaC3")
        {
            if (onPlayerStop != null)
                onPlayerStop();
        }

        if (other.tag == "AreaD1")
        {
            if (onPlayerStop != null)
                onPlayerStop();
        }

        if (other.tag == "AreaD2")
        {
            if (onPlayerStop != null)
                onPlayerStop();
        }
    }
}

