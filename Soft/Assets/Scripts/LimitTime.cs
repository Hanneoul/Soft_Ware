using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LimitTime : MonoBehaviour
{
    public float limit_Time;
    public Text timeText;

    void Start()
    {
        
    }

    void Update()
    {
        limit_Time -= Time.deltaTime;
        timeText.text = limit_Time.ToString("N0");
        if(limit_Time <= 0)
        {
            timeText.text = "½ÇÆÐ";
        }
    }
}
