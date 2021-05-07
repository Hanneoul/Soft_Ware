using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float x;
    public float z;

    public float hp; // HP

    public float tower1_damage; // tower1�� ���ݷ�
    public float drop_money; // ����Ӵ�

    public GameManager gm;
    StageManager stageManager;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        stageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    void Update()
    {
        Survive();
        Die();
    }

    void Survive( )
    {
        if (this.gameObject.transform.position.x >= x 
            && this.gameObject.transform.position.z >= z)
        {
            Debug.Log("��Ҵ�"); 
            this.transform.parent.GetComponent<SpawnManager>().Push(gameObject);
            stageManager.surviveCnt++;
        }
    }

    void Die()
    {
        if (hp <= 0)
        {
            Debug.Log("�׾���");
            this.transform.parent.GetComponent<SpawnManager>().Push(gameObject);
            gm.money += drop_money;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("�¾Ҵ�");
        if (other.CompareTag("Tower_Attack"))
        {
            hp -= tower1_damage;

            //if (hp <= 0)
            //{
            //   Destroy(gameObject);
            //   Debug.Log("�׾���");
            //   gm.money += drop_money;
            //}
        }
    }
}
