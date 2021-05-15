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
        Debug.Log("¸Â¾Ò´Ù");
        if(other.gameObject.CompareTag("Enemy"))
        {
            enemy.hp -= atk;
            Debug.Log("¿Ö ¾È´â¾Æ ¾¾¹ß");
        }
    }
}
