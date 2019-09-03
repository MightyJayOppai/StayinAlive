using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("Player Movement Variables")]
    [SerializeField] private float walkingSpeed = 0f;
    [SerializeField] private float runningSpeed = 0f;
    [Range(0f, 10.0f)] [SerializeField] private float rotationSpeed = 0f;
    private float gravity = 0f;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController charController;
    [SerializeField] private float defaultGravity = 0f;

    [Header("Cheats Section :3")]
    [SerializeField] private float flashSpeed = 0f;
    [SerializeField] private float defaultRunningSpeed = 0f;
    private float moveHorizontal = 0f;
    private float moveVertical = 0f;
    private enum InputType { Keyboard, Gamepad };
    [SerializeField] private InputType input = InputType.Keyboard;

    void Start()
    {
        charController = GetComponent<CharacterController>();
        gravity = defaultGravity;
    }

    void Update()
    {
        if (input == InputType.Keyboard)
        {
            //Gets Player Inputs
            moveVertical = Input.GetAxis("Horizontal");
            moveHorizontal = Input.GetAxis("Vertical");
        }

        if (input == InputType.Gamepad)
        {
            
        }

            moveDirection = new Vector3(moveVertical, 0.0f, moveHorizontal);
        moveDirection = moveDirection.normalized;

        if (moveDirection != Vector3.zero)
            transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.LookRotation(moveDirection), rotationSpeed * Time.deltaTime);

        charController.Move(moveDirection * walkingSpeed * Time.deltaTime);
        moveDirection.y -= gravity * Time.deltaTime;
    }
}