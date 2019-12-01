using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public GameObject oldProp;
    public GameObject newProp;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && KeyItem.keyItemCount>0)
        {
            KeyItem.keyItemCount--;
            oldProp.SetActive(false);
            newProp.SetActive(true);
        }
    }
}
