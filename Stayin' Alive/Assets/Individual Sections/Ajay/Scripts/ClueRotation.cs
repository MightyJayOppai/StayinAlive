using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueRotation : MonoBehaviour
{
    public Camera obCam;
    Vector3 mPrevPos = Vector3.zero;
    Vector3 mPosDelta = Vector3.zero;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mPosDelta = Input.mousePosition - mPrevPos;

            if(Vector3.Dot(transform.up, Vector3.up) >= 0)
            {
                transform.Rotate(transform.up, -Vector3.Dot(mPosDelta, obCam.transform.right), Space.World);
            }
            else
            {
                transform.Rotate(transform.up, Vector3.Dot(mPosDelta, obCam.transform.right), Space.World);
            }

            transform.Rotate(obCam.transform.right, Vector3.Dot(mPosDelta, obCam.transform.up), Space.World);
        }
        
        mPrevPos = Input.mousePosition;
    }
}
