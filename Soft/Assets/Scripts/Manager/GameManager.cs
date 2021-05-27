using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI totalMoneyText;

    public float money; //초기지급머니
    public float totalMoney; //번 돈

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            Debug.Log("GameManager : Object Creation Complete.");
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        Money();
    }
    
    public void Money()
    {
        moneyText.text = money.ToString();
        totalMoneyText.text = totalMoney.ToString();
    }
}
