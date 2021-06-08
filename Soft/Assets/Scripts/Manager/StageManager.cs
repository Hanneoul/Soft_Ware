using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    public float limit_Time;
    public float surviveCnt;
    public float failCnt;

    bool stageStart = false;
    public Text timeText;
        

    void Update()
    {
        if (stageStart)
        {
            limit_Time -= Time.deltaTime;
        }

        timeText.text = limit_Time.ToString("N0");

        if (limit_Time <= 0)
        {
            timeText.text = "시간제한 실패";
            Time.timeScale = 0;
        }

        if(surviveCnt >= failCnt)
        {
            Time.timeScale = 0;
            timeText.text = "놓쳐서 실패";
        }
    }
    public void TimeGo()
    {
        stageStart = true;
    }

}
