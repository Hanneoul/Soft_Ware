using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LimitTime : MonoBehaviour
{
    bool stageStart = false;
    public float limit_Time;
    public Text timeText;

    void Start()
    {
        
    }

    void Update()
    {
        if (stageStart)
        {
            limit_Time -= Time.deltaTime;
        }

        timeText.text = limit_Time.ToString("N0");

        if (limit_Time <= 0)
        {
            timeText.text = "½ÇÆÐ";
            Time.timeScale = 0;
        }
        
    }
    public void TimeGo()
    {
        stageStart = true;
    }
}
