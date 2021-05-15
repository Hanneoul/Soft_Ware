using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    public Text moneyText;
    public float money;

    public float surviveCnt;
    public float failCnt;

    void Update()
    {
        Wallet();
        RoundFail();
    }

    void Wallet()
    {
        moneyText.text = money.ToString();
    }

    void RoundFail()
    {
        if (surviveCnt == failCnt)
        {
            //fail_Img Ãâ·Â
        }
    }
}
