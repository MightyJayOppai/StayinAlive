using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement Variables")]
    [SerializeField] private float playerSpeed = 0f;
    [Range(0f, 10.0f)] [SerializeField] private float rotationSpeed = 0f;
    private float gravity = 0f;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController charController;
    [SerializeField] private float defaultGravity = 0f;
    private float moveHorizontal = 0f;
    private float moveVertical = 0f;
    
    [Header("Input Type")]
    private Vector3 playerVector = Vector3.zero;

    [Header("Cam Variables")]
    [SerializeField] private Transform camPos;

    public ClueLog clueLog;
    public HUD Hud;
    void Start()
    {
        charController = GetComponent<CharacterController>();
        gravity = defaultGravity;
    }

    void Update()
    {
        moveVertical = Input.GetAxis("Horizontal");
        moveHorizontal = Input.GetAxis("Vertical");

        if (charController.isGrounded)
        {
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
        }
        else
        {
            playerVector.y -= gravity * Time.deltaTime;
        }

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
