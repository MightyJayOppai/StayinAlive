using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
     public GameObject accFilesBG;
    public GameObject accTextBG;
    public GameObject accFilesText;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(player.transform.position,this.transform.position));
        if(Vector3.Distance(player.transform.position,this.transform.position)<2){
            accTextBG.SetActive(true);
            accFilesText.SetActive(true);
            if( Input.GetKeyDown(KeyCode.E))
            {
                accTextBG.SetActive(false);
                accFilesBG.SetActive(true);
            }
        }
        else{
            accTextBG.SetActive(false);
            accFilesText.SetActive(false);
        }
    }
}
