using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    public static int keyItemCount;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            keyItemCount += 1;
            Destroy (gameObject);
        }
    }
}
