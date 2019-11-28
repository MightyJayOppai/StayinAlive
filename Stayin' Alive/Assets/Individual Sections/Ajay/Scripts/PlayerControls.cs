using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    private float horizontalAxis;
    private float verticalAxis;
    [Range(0f, 10.0f)] [SerializeField] private float rotationSpeed = 0f;
    public float playerSpeed;
    private CharacterController charController;
    public Camera camera;
    private Vector3 moveDirection = Vector3.zero;
    
    void Start()
    {
        camera = GetComponent<Camera>();
        charController = GetComponent<CharacterController>();
    }
    void FixedUpdate() 
    {
        // reading the input:
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");

        //moveDirection = new Vector3(verticalAxis, 0f, horizontalAxis);
        //moveDirection = moveDirection.normalized;

        // assuming we only using the single camera:
        camera = Camera.main;
        // camera forward and right vectors:
        Vector3 forward = camera.transform.forward;
        Vector3 right = camera.transform.right;
        // project forward and right vectors on the horizontal plane (y = 0)
        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();
        // this is the direction in the world space we want to move:
        Vector3 desiredMoveDirection = ((forward * verticalAxis) + (right * horizontalAxis));
        // now we can apply the movement:
        transform.Translate((desiredMoveDirection * (playerSpeed * Time.deltaTime)));

        if (desiredMoveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.LookRotation(desiredMoveDirection), rotationSpeed * Time.deltaTime);
        }
    }

}