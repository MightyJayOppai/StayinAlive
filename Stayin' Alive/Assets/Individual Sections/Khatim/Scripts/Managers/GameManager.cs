using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject detectiveModeUI;
    [SerializeField] private GameObject detectiveObj;
    [SerializeField] private GameObject rotatingObj;
    [SerializeField] private Transform detectiveObjPos;
    [SerializeField] private Vector3 upscaleValue;
    [SerializeField] private bool isInDetectiveMode;
    [SerializeField] private float rotateSpeed;

    void OnEnable()
    {
        PlayerControls.onDetectiveUIEnable += OnDetectiveUIEnableEventReceived;
    }

    void OnDisable()
    {
        PlayerControls.onDetectiveUIEnable -= OnDetectiveUIEnableEventReceived;
    }

    void OnDestroy()
    {
        PlayerControls.onDetectiveUIEnable -= OnDetectiveUIEnableEventReceived;
    }

    void Update()
    {
        if (isInDetectiveMode)
        {
            float rotateX = Input.GetAxis("Mouse X");
            float rotateY = Input.GetAxis("Mouse Y");

            if (Input.GetMouseButton(0))
            {
                rotatingObj.transform.Rotate(Vector3.up, -rotateX);
                rotatingObj.transform.Rotate(Vector3.right, rotateY);
            }
        }
    }

    void OnDetectiveUIEnableEventReceived(GameObject obj)
    {
        detectiveObj = obj;
        ShowObjOnUI();
        PlayerControls.onDetectiveUIEnable -= OnDetectiveUIEnableEventReceived;
    }

    void ShowObjOnUI()
    {
        isInDetectiveMode = true;
        detectiveModeUI.SetActive(true);
        GameObject intantiateObj = Instantiate(detectiveObj, detectiveObjPos.position, detectiveObjPos.rotation, detectiveObjPos);
        rotatingObj = intantiateObj;
        intantiateObj.transform.localScale = upscaleValue;
    }
}