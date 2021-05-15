using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    StageManager stageManager;

    public Tower1 t1;
    public Tower2 t2;
    public Tower3 t3;

    public float hp;

    public float x;
    public float z;

    public float dropMoney;

    void Start()
    {
        stageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    void Update()
    {
        Survive();
        Die();
    }

    void Die()
    {
        if (hp <= 0)
        {
            Debug.Log("죽음");
            this.transform.parent.GetComponent<Spawner>().Push(gameObject);
            stageManager.money += dropMoney;
        }
    }

    void Survive()
    {
        if (this.gameObject.transform.position.x >= x && this.gameObject.transform.position.z >= z)
        {
            this.transform.parent.GetComponent<Spawner>().Push(gameObject);
            stageManager.surviveCnt++;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Coffee1"))
        {
            Debug.Log("dd");
            //hp = hp - damage;
            hp = hp - t1.Tower1_AttackPower;
            if (hp <= 0)
            {
                //die 애니메이션 출력
                Debug.Log("죽음");
            }
        }

        if (other.gameObject.CompareTag("Coffee2"))
        {
            //hp = hp - damage;
            hp = hp - t2.Tower2_AttackPower;
            if (hp <= 0)
            {
                //die 애니메이션 출력
                Debug.Log("죽음");
            }
        }

        if (other.gameObject.CompareTag("Coffee3"))
        {
            //hp = hp - damage;
            hp = hp - t3.Tower3_AttackPower;
            if (hp <= 0)
            {
                //die 애니메이션 출력
                Debug.Log("죽음");
            }
        }
    }
}