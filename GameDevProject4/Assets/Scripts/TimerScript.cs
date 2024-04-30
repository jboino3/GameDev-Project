using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimerScript : MonoBehaviour
{
    float currentTime = 0f;
    public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        currentTime +=   1 * Time.deltaTime;
        timerText.text = "Time: " + currentTime.ToString("0.0");
    }
}
