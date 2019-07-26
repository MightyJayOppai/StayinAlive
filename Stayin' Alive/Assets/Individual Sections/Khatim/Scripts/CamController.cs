using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{

    [SerializeField] private GameObject vCam1;
    [SerializeField] private GameObject vCam2;
    [SerializeField] private GameObject vCam3;

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "VCam")
        {
            vCam1.SetActive(true);
            vCam2.SetActive(false);
            vCam3.SetActive(false);
        }

        if (other.tag == "VCam2")
        {
            vCam1.SetActive(false);
            vCam2.SetActive(true);
            vCam3.SetActive(false);
        }

        if (other.tag == "VCam3")
        {
            vCam1.SetActive(false);
            vCam2.SetActive(false);
            vCam3.SetActive(true);
        }
    }
}