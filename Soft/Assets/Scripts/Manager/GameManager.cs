using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager gameManager = null;

    public TextMeshProUGUI moneyText;

    public float money; //초기지급머니
    //public float drop_money; // 드랍머니

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
