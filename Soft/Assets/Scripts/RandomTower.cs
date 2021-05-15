using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTower : MonoBehaviour
{
    public float atk_Min;
    public float atk_Max;
    public float atk;

    public Enemy enemy;

    void Start()
    {
        
    }

    void Update()
    {
        RandomAtk();
    }

    void RandomAtk()
    {
        atk = Random.Range(atk_Min, atk_Max);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("�¾Ҵ�");
        if(other.gameObject.CompareTag("Enemy"))
        {
            enemy.hp -= atk;
            Debug.Log("�� �ȴ�� ����");
        }
    }
}
