using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager gameManager = null;

    public TextMeshProUGUI moneyText;

    public float money; //�ʱ����޸Ӵ�
    //public float drop_money; // ����Ӵ�

    void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
            Debug.Log("GameManager : Object Creation Complete.");
        }
        else if (gameManager != null)
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
    }
}
