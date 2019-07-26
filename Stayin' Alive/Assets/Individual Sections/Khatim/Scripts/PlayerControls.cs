using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("Player Movement Variables")]
    [SerializeField] private float walkingSpeed;
    [Range(0f, 10.0f)]
    [SerializeField] private float rotationSpeed;

    [Header("Player Gravity Variables")]
    [SerializeField] private float defaultGravity;

    public delegate void SendEvents();

    private float gravity;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController charController;
    private float moveHorizontal;
    private float moveVertical;


    void OnEnable()
    {
        charController = GetComponent<CharacterController>();
        gravity = defaultGravity;
    }

    void Update()
    {
        //Gets Player Inputs
        moveVertical = Input.GetAxis("Horizontal");
        moveHorizontal = Input.GetAxis("Vertical");

        if (charController.isGrounded)
        {
            moveDirection = new Vector3(moveVertical, 0.0f, moveHorizontal);
            moveDirection = moveDirection.normalized;

            if (moveDirection != Vector3.zero)
                transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.LookRotation(moveDirection), rotationSpeed * Time.deltaTime);
        }
        else
            moveDirection.y -= gravity * Time.deltaTime;

        charController.Move(moveDirection * walkingSpeed * Time.deltaTime);
    }
}