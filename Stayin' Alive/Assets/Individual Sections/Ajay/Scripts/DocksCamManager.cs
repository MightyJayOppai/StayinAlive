using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocksCamManager : MonoBehaviour
{
    [SerializeField] private GameObject DCamA1;
    [SerializeField] private GameObject DCamA2;
    [SerializeField] private GameObject DCamA3;
    [SerializeField] private GameObject DCamB1;
    [SerializeField] private GameObject DCamB2;
    [SerializeField] private GameObject DCamB3;
    [SerializeField] private GameObject DCamC1;
    [SerializeField] private GameObject DCamC2;
    [SerializeField] private GameObject DCamD1;
    [SerializeField] private GameObject DCamD2;
    [SerializeField] private GameObject DCamD3;
    [SerializeField] private GameObject DCamE1;
    [SerializeField] private GameObject DCamE2;
    [SerializeField] private GameObject DCamF1;
    [SerializeField] private GameObject DCamF2;
    [SerializeField] private GameObject DCamF3;
    [SerializeField] private GameObject DCamF4;
    [SerializeField] private GameObject DCamF5;
    [SerializeField] private GameObject DCamF6;
    [SerializeField] private GameObject DCamG1;
    [SerializeField] private GameObject DCamG2;
    [SerializeField] private GameObject DCamG3;
    [SerializeField] private GameObject DCamG4;
    [SerializeField] private GameObject DCamG5;
    [SerializeField] private GameObject DCamG6;
    [SerializeField] private GameObject DCamG7;
    [SerializeField] private GameObject DCamG8;
    [SerializeField] private GameObject DCamG9;
    [SerializeField] private GameObject DCamG10;
    [SerializeField] private GameObject DCamH1;
    [SerializeField] private GameObject DCamH2;
    [SerializeField] private GameObject DCamH3;
        
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AreaA1")
        {
            DCamA1.SetActive(true);
            DCamA2.SetActive(false);
            DCamA3.SetActive(false);
            DCamF1.SetActive(false);
            DCamF4.SetActive(false);
            Debug.Log("Cam Switched to DCamA1");
        }

        if (other.tag == "AreaA2")
        {
            DCamA2.SetActive(true);
            DCamA1.SetActive(false);
            DCamA3.SetActive(false);
            DCamG2.SetActive(false);
            Debug.Log("Cam Switched to DCamA2");
        }

        if (other.tag == "AreaA3")
        {
            DCamA3.SetActive(true);
            DCamA1.SetActive(false);
            DCamA2.SetActive(false);
            Debug.Log("Cam Switched to DCamA3");
        }

        if (other.tag == "AreaB1")
        {
            DCamB1.SetActive(true);
            DCamC2.SetActive(false);
            DCamB2.SetActive(false);
            DCamG1.SetActive(false);
            Debug.Log("Cam Switched to DCamB1");
        }

        if (other.tag == "AreaB2")
        {
            DCamB2.SetActive(true);
            DCamB1.SetActive(false);
            DCamB3.SetActive(false);
            DCamE1.SetActive(false);
            DCamG1.SetActive(false);
            Debug.Log("Cam Switched to DCamB2");
        }

        if (other.tag == "AreaB3")
        {
            DCamB3.SetActive(true);
            DCamB2.SetActive(false);
            DCamF1.SetActive(false);
            DCamF4.SetActive(false);
            Debug.Log("Cam Switched to DCamB3");
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
            DCamH1.SetActive(false);
            DCamH3.SetActive(false);
            Debug.Log("Cam Switched to DCamD3");
        }

        if (other.tag == "AreaE1")
        {
            DCamE1.SetActive(true);
            DCamE2.SetActive(false);
            DCamB2.SetActive(false);
            Debug.Log("Cam Switched to DCamE1");
        }

        if (other.tag == "AreaE2")
        {
            DCamE2.SetActive(true);
            DCamE1.SetActive(false);
            DCamA1.SetActive(false);
            Debug.Log("Cam Switched to DCamE2");
        }

        if (other.tag == "AreaF1")
        {
            DCamF1.SetActive(true);
            DCamA1.SetActive(false);
            DCamA2.SetActive(false);
            DCamF4.SetActive(false);
            DCamF2.SetActive(false);
            Debug.Log("Cam Switched to DCamF1");
        }

        if (other.tag == "AreaF2")
        {
            DCamF2.SetActive(true);
            DCamF1.SetActive(false);
            DCamF3.SetActive(false);
            Debug.Log("Cam Switched to DCamF2");
        }

        if (other.tag == "AreaF3")
        {
            DCamF3.SetActive(true);
            DCamF1.SetActive(false);
            DCamF2.SetActive(false);
            Debug.Log("Cam Switched to DCamF3");
        }

        if (other.tag == "AreaF4")
        {
            DCamF4.SetActive(true);
            DCamB3.SetActive(false);
            DCamF1.SetActive(false);
            DCamF5.SetActive(false);
            DCamA1.SetActive(false);
            Debug.Log("Cam Switched to DCamF4");
        }

        if (other.tag == "AreaF5")
        {
            DCamF5.SetActive(true);
            DCamF4.SetActive(false);
            DCamF6.SetActive(false);
            Debug.Log("Cam Switched to DCamF5");
        }

        if (other.tag == "AreaF6")
        {
            DCamF6.SetActive(true);
            DCamF4.SetActive(false);
            DCamF5.SetActive(false);
            Debug.Log("Cam Switched to DCamF6");
        }

        if (other.tag == "AreaG1")
        {
            DCamG1.SetActive(true);
            DCamB1.SetActive(false);
            DCamB2.SetActive(false);
            DCamG2.SetActive(false);
            DCamG3.SetActive(false);
            DCamG4.SetActive(false);
            DCamG5.SetActive(false);
            DCamG10.SetActive(false);
            Debug.Log("Cam Switched to DCamG1");
        }

        if (other.tag == "AreaG2")
        {
            DCamG2.SetActive(true);
            DCamA2.SetActive(false);
            DCamG1.SetActive(false);
            DCamG6.SetActive(false);
            DCamG7.SetActive(false);
            DCamG8.SetActive(false);
            DCamG9.SetActive(false);
            Debug.Log("Cam Switched to DCamG2");
        }

        if (other.tag == "AreaG3")
        {
            DCamG3.SetActive(true);
            DCamG1.SetActive(false);
            Debug.Log("Cam Switched to DCamG3");
        }

        if (other.tag == "AreaG4")
        {
            DCamG4.SetActive(true);
            DCamG1.SetActive(false);
            Debug.Log("Cam Switched to DCamG4");
        }

        if (other.tag == "AreaG5")
        {
            DCamG5.SetActive(true);
            DCamG1.SetActive(false);
            DCamG2.SetActive(false);
            Debug.Log("Cam Switched to DCamG5");
        }

        if (other.tag == "AreaG6")
        {
            DCamG6.SetActive(true);
            DCamG2.SetActive(false);
            Debug.Log("Cam Switched to DCamG6");
        }

        if (other.tag == "AreaG7")
        {
            DCamG7.SetActive(true);
            DCamG2.SetActive(false);
            Debug.Log("Cam Switched to DCamG7");
        }

        if (other.tag == "AreaG8")
        {
            DCamG8.SetActive(true);
            DCamG2.SetActive(false);
            Debug.Log("Cam Switched to DCamG8");
        }

        if (other.tag == "AreaG9")
        {
            DCamG9.SetActive(true);
            DCamG2.SetActive(false);
            Debug.Log("Cam Switched to DCamG9");
        }

        if (other.tag == "AreaG10")
        {
            DCamG10.SetActive(true);
            DCamG1.SetActive(false);
            Debug.Log("Cam Switched to DCamG10");
        }


        if (other.tag == "AreaH1")
        {
            DCamH1.SetActive(true);
            DCamH2.SetActive(false);
            DCamH3.SetActive(false);
            DCamD3.SetActive(false);
            Debug.Log("Cam Switched to DCamH1");
        }

        if (other.tag == "AreaH2")
        {
            DCamH2.SetActive(true);
            DCamH1.SetActive(false);
            DCamH3.SetActive(false);
            DCamD3.SetActive(false);
            Debug.Log("Cam Switched to DCamH2");
        }

        if (other.tag == "AreaH3")
        {
            DCamH3.SetActive(true);
            DCamH2.SetActive(false);
            DCamH1.SetActive(false);
            DCamD3.SetActive(false);
            Debug.Log("Cam Switched to DCamH3");
        }
    }
}
