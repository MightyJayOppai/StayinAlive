using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocksCamManager : MonoBehaviour
{
    [SerializeField] private GameObject DCamA1;
    [SerializeField] private GameObject DCamA2;
    [SerializeField] private GameObject DCamA3;
    [SerializeField] private GameObject DCamC1;
    [SerializeField] private GameObject DCamC2;
    [SerializeField] private GameObject DCamD1;
    [SerializeField] private GameObject DCamD2;
    [SerializeField] private GameObject DCamD3;

    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AreaA1")
        {
            DCamA1.SetActive(true);
            DCamA2.SetActive(false);
            DCamA3.SetActive(false);
            Debug.Log("Cam Switched to DCamA1");
        }

        if (other.tag == "AreaA2")
        {
            DCamA2.SetActive(true);
            DCamA1.SetActive(false);
            DCamA3.SetActive(false);
            Debug.Log("Cam Switched to DCamA2");
        }

        if (other.tag == "AreaA3")
        {
            DCamA3.SetActive(true);
            DCamA1.SetActive(false);
            DCamA2.SetActive(false);
            Debug.Log("Cam Switched to DCamA3");
        }

        if (other.tag == "AreaC1")
        {
            DCamC1.SetActive(true);
            DCamA3.SetActive(false);
            DCamC2.SetActive(false);
            Debug.Log("Cam Switched to DCamC1");
        }

        if (other.tag == "AreaC2")
        {
            DCamC2.SetActive(true);
            DCamC1.SetActive(false);
            Debug.Log("Cam Switched to DCamC2");
        }

        if (other.tag == "AreaD1")
        {
            DCamD1.SetActive(true);
            DCamC2.SetActive(false);
            DCamC1.SetActive(false);
            Debug.Log("Cam Switched to DCamD1");
        }
        if (other.tag == "AreaD2")
        {
            DCamD2.SetActive(true);
            DCamD1.SetActive(false);
            DCamC1.SetActive(false);
            Debug.Log("Cam Switched to DCamD2");
        }
        if (other.tag == "AreaD3")
        {
            DCamD3.SetActive(true);
            DCamD2.SetActive(false);
            DCamD1.SetActive(false);
            Debug.Log("Cam Switched to DCamD3");
        }
    }
}
