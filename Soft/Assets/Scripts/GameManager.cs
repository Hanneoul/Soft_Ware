using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public GameObject mob;

    public Enemy enemy;

    public TextMeshProUGUI moneyText; 

    public float money; //�ʱ����޸Ӵ�
    //public float drop_money; // ����Ӵ�

    void Start()
    {
        
    }

    void Update()
    {
        moneyText.text = money.ToString();

    }

    public void MobInstantiate()
    {
        //Instantiate(mob, mob.transform.position, Quaternion.Euler(270, 0, 90));
        Instantiate(mob, transform.parent);
    }
}
