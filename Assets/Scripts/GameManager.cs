using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text moneyText;
    public float money;

    public float surviveCnt;
    public float failCnt;

    void Start()
    {
        money = 0;

        InvokeRepeating("AutoMoney", 1, 1);
    }

    void Update()
    {
        Wallet();
        RoundFail();
    }

    void AutoMoney()
    {
        money += 10;
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
            Debug.Log("Fail");
        }
    }
}
