using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerTest : MonoBehaviour
{
    [SerializeField] private Transform camPivot;
    [SerializeField] private float playerSpeed = 0f;
    private float heading = 0f;
    [SerializeField] private Transform camPos;
    private Vector2 playerInput;

    void Update()
    {
        heading += Input.GetAxis("Mouse X");
        if (camPivot != null)
            camPivot.rotation = Quaternion.Euler(0f, heading, 0f);

        playerInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        playerInput = Vector2.ClampMagnitude(playerInput, 1);

        Vector3 camForward = camPos.forward;
        Vector3 camRight = camPos.right;

        camForward.y = 0f;
        camRight.y = 0f;
        camForward = camForward.normalized;
        camRight = camRight.normalized;

        // transform.position += new Vector3(playerInput.x, 0f, playerInput.y) * Time.deltaTime * playerSpeed;
        transform.position += (camForward * playerInput.y + camRight * playerInput.x) * Time.deltaTime * playerSpeed;
    }
}