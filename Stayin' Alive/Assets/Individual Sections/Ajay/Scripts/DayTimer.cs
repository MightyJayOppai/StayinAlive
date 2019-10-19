using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DayTimer : MonoBehaviour
{
    public float currentTime;
    public float startingTime;
    
    [SerializeField]
    Text timerCountDownText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerCountDownText.text = currentTime.ToString("0");

        if(currentTime < 0)
        {
            currentTime = 0;
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }
}
