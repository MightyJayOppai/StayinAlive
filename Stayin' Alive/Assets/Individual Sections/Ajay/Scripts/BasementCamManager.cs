using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasementCamManager : MonoBehaviour
{
    [SerializeField] private GameObject bCamA1;
    [SerializeField] private GameObject bCamA2;
    [SerializeField] private GameObject bCamA3;
    [SerializeField] private GameObject bCamB1;
    [SerializeField] private GameObject bCamB2;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AreaA1")
        {
            bCamA1.SetActive(true);
            bCamA2.SetActive(false);
            bCamA3.SetActive(false);
            bCamB1.SetActive(false);
            Debug.Log("Cam Switched to bCamA1");
        }

        if (other.tag == "AreaA2")
        {
            bCamA2.SetActive(true);
            bCamA1.SetActive(false);
            bCamA3.SetActive(false);
            bCamB1.SetActive(false);
            Debug.Log("Cam Switched to bCamA2");
        }

        if (other.tag == "AreaA3")
        {
            bCamA3.SetActive(true);
            bCamA2.SetActive(false);
            bCamA1.SetActive(false);
            bCamB1.SetActive(false);
            Debug.Log("Cam Switched to bCamA3");
        }

        if (other.tag == "AreaB1")
        {
            bCamB1.SetActive(true);
            bCamA2.SetActive(false);
            bCamA1.SetActive(false);
            bCamA3.SetActive(false);
            bCamB2.SetActive(false);
            Debug.Log("Cam Switched to bCamB1");
        }

        if (other.tag == "AreaB2")
        {
            bCamB2.SetActive(true);
            bCamA2.SetActive(false);
            bCamA1.SetActive(false);
            bCamA3.SetActive(false);
            bCamB1.SetActive(false);
            Debug.Log("Cam Switched to bCamB2");
        }
    }
}
