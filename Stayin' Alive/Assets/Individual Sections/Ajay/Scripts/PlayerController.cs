using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement Variables")]
    [SerializeField] private float playerSpeed;
    [SerializeField] private float gravity;
    public Transform groundCheck;
    Vector3 velocity;
    bool isGrounded;
    [SerializeField] private float groundDistance;
    public LayerMask groundMask;
    [Range(0f, 10.0f)] [SerializeField] private float rotationSpeed = 0f;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController charController;
    private float moveHorizontal = 0f;
    private float moveVertical = 0f;
    
    [Header("Input Type")]
    private InputPlayer playerInput;
    private Vector3 playerVector = Vector3.zero;


    [Header("Cam Variables")]
    [SerializeField] private Transform camPos;

    Rigidbody rigidBody;
    public ClueLog clueLog;
    public HUD Hud;
    private Animator anim;
    void Start()
    {
        charController = GetComponent<CharacterController>();
        rigidBody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if(isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }
            moveVertical = Input.GetAxis("Horizontal");
            moveHorizontal = Input.GetAxis("Vertical");

            moveDirection = new Vector3(moveVertical, 0f, moveHorizontal);
            moveDirection = moveDirection.normalized;

            // if (moveDirection != Vector3.zero)
            //     transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.LookRotation(-moveDirection), rotationSpeed * Time.deltaTime);

            Vector3 camForward = camPos.forward;
            Vector3 camRight = camPos.right;
            camForward.y = 0f;
            camRight.y = 0f;
            camForward = camForward.normalized;
            camRight = camRight.normalized;

            playerVector = camForward * moveDirection.z + camRight * moveDirection.x;
            playerVector = playerVector.normalized;

            velocity.y += gravity * Time.deltaTime;
            charController.Move(velocity * Time.deltaTime);
            //transform.position = transform.position + velocity * Time.deltaTime;

        if (playerVector != Vector3.zero)
        {
            transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.LookRotation(playerVector), rotationSpeed * Time.deltaTime);
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }
           charController.Move(playerVector * playerSpeed * Time.deltaTime);
           //transform.position = transform.position + playerVector * playerSpeed * Time.deltaTime;
            //Debug.Log(playerVector);

        if (mItemToPickup != null && Input.GetKeyDown(KeyCode.E))
        {
            clueLog.AddItem(mItemToPickup);
            mItemToPickup.OnPickUp();
            Hud.CloseMessagePanel();
        }
    }
    private IClueItem mItemToPickup = null;
    
    private void OnTriggerEnter(Collider other) 
    {
        IClueItem item = other.GetComponent<IClueItem>();
        if (item != null)
        {
            //clueLog.AddItem(item);
            //item.OnPickUp();
            mItemToPickup = item;
            Hud.OpenMessagePanel("");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        IClueItem item = other.GetComponent<IClueItem>();
        if (item != null)
        {
            mItemToPickup = null;
            Hud.CloseMessagePanel();
        }
    }
}
