using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameManager gm;
    public float hp;

    public float x;
    public float z;

    public float dropMoney;

    void Update()
    {
        Survive();
        Die();
    }

    void Die()
    {
        if (hp == 0)
        {
            this.transform.parent.GetComponent<Spawner>().Push(gameObject);
            gm.money += dropMoney;
        }
    }

    void Survive()
    {
        if (this.gameObject.transform.position.x >= x && this.gameObject.transform.position.z >= z)
        {
            this.transform.parent.GetComponent<Spawner>().Push(gameObject);
            gm.surviveCnt++;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coffee"))
        {
            //hp = hp - damage;
            hp = hp - 1;
            Debug.Log("으악");
            if (hp == 0)
            {
                //die 애니메이션 출력
                Debug.Log("죽음");
            }
        }
    }
}