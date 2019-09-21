﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [Header("Player Movement Variables")]
    [SerializeField] private float walkingSpeed = 0f;
    [SerializeField] private float runningSpeed = 0f;
    [Range(0f, 10.0f)] [SerializeField] private float rotationSpeed = 0f;
    private float gravity = 0f;
    private Vector3 moveDirection = Vector3.zero;
    private Vector2 moveDirectionJoy = Vector2.zero;
    private CharacterController charController;
    [SerializeField] private float defaultGravity = 0f;

    private float moveHorizontal = 0f;
    private float moveVertical = 0f;
    private enum InputType { Keyboard, Gamepad };

    [Header("Input Type")]
    [SerializeField] private InputType input = InputType.Keyboard;
    private InputPlayer playerInput;
    private Vector3 playerVector = Vector3.zero;

    [Header("Cam Variables")]
    [SerializeField] private Transform camPos;

    // Watch this video https://www.youtube.com/watch?v=bV1sB2vHDAw and https://forum.unity.com/threads/moving-character-relative-to-camera.383086/

    void Awake()
    {
        playerInput = new InputPlayer();

        playerInput.Player.Movement.performed += ctx => moveDirectionJoy = ctx.ReadValue<Vector2>();
        playerInput.Player.Movement.canceled += ctx => moveDirectionJoy = Vector2.zero;
    }

    void Start()
    {
        charController = GetComponent<CharacterController>();
        gravity = defaultGravity;
    }

    void OnEnable()
    {
        playerInput.Player.Enable();
    }

    void OnDisable()
    {
        playerInput.Player.Disable();
    }

    void Update()
    {
        if (input == InputType.Keyboard)
        {
            //Gets Player Inputs
            moveVertical = Input.GetAxis("Horizontal");
            moveHorizontal = Input.GetAxis("Vertical");
            // Debug.Log("Gamepad Intialised");
        }

        if (input == InputType.Gamepad)
        {
            if (moveDirectionJoy != Vector2.zero)
            {
                moveHorizontal = moveDirectionJoy.y;
                moveVertical = moveDirectionJoy.x;
            }
            else
            {
                moveHorizontal = 0f;
                moveVertical = 0f;
            }
            // Debug.Log("Gamepad Intialised");
        }

        if (charController.isGrounded)
        {
            moveDirection = new Vector3(-moveVertical, 0f, moveHorizontal);
            moveDirection = moveDirection.normalized;

            if (moveDirection != Vector3.zero)
                transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.LookRotation(moveDirection), rotationSpeed * Time.deltaTime);

            Vector3 camForward = camPos.forward;
            Vector3 camRight = camPos.right;
            camForward.y = 0f;
            camRight.y = 0f;
            camForward = camForward.normalized;
            camRight = camRight.normalized;

            playerVector = camRight * moveDirection.z + camForward * moveDirection.x;
            playerVector = playerVector.normalized;
        }
        else
            playerVector.y -= gravity * Time.deltaTime;


        charController.Move(playerVector * walkingSpeed * Time.deltaTime);
        // charController.Move(moveDirection * walkingSpeed * Time.deltaTime);
    }
}