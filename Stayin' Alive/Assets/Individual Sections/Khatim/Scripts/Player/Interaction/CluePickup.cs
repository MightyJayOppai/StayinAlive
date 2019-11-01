using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CluePickup : PlayerInteraction
{
    private PlayerControls plyControls;

    void OnEnable()
    {
        plyControls = GetComponent<PlayerControls>();
    }

    public override void StartInteraction()
    {
        base.StartInteraction();
        Debug.Log("Clue Picking Started");
    }
    public override void UpdateInteraction()
    {
        Debug.Log("Clue Picking Progress");
    }
    public override void EndInteraction()
    {
        base.EndInteraction();
        Debug.Log("Clue Picking Ended");
    }
}