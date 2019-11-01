using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Collider interactCol;
    // public Rigidbody rgObject;


    public virtual void StartInteraction()
    {
        // rgObject = interactCol.GetComponent<Rigidbody>();
    }

    public virtual void UpdateInteraction()
    {

    }

    public virtual void EndInteraction()
    {
        // rgObject = null;
    }
}