using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerTest : MonoBehaviour
{
    [SerializeField] private Transform camPivot;
    [SerializeField] private float playerSpeed = 0f;
    private float heading = 0f;
    [SerializeField] private bool isStopped;
    [SerializeField] private float currTime;
    [SerializeField] private float stoppingTime;
    [SerializeField] private Transform camPos;
    private Vector2 input;
    private CharacterController charControllerTest;

    void OnEnable()
    {
        VCamManager.onPlayerStop += OnPlayerStoppedEventReceived;
    }

    void OnDisable()
    {
        VCamManager.onPlayerStop -= OnPlayerStoppedEventReceived;
    }

    void OnDestroy()
    {
        VCamManager.onPlayerStop -= OnPlayerStoppedEventReceived;
    }

    void Start()
    {
        charControllerTest = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (camPivot != null)
        {
            heading += Input.GetAxis("Mouse X");
            camPivot.rotation = Quaternion.Euler(0f, heading, 0f);
        }

        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input, 1);

        Vector3 camForward = camPos.forward;
        Vector3 camRight = camPos.right;

        camForward.y = 0f;
        camRight.y = 0f;
        camForward = camForward.normalized;
        camRight = camRight.normalized;

        Vector3 playerVector = camForward * input.y + camRight * input.x;


        if (!isStopped)
            charControllerTest.Move(playerVector * playerSpeed * Time.deltaTime);
        // transform.position += (camForward * input.y + camRight * input.x) * Time.deltaTime * playerSpeed;
        else
        {
            currTime += Time.deltaTime;

            if (currTime >= stoppingTime)
            {
                isStopped = false;
                currTime = 0f;
            }
        }
    }

    void OnPlayerStoppedEventReceived()
    {
        isStopped = true;
    }
}