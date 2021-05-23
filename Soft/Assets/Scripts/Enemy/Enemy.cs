using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Enemy : MonoBehaviour
{
    public float x;
    public float z;

    public TextMesh hpText;
    public float hp; // HP

    public Tower tower1; // tower1�� ���ݷ�
    public Tower tower2;
    public Tower ex_Tower;
    public RandomTower rdTower;

    public float enemy_drop_money; // ����Ӵ�

    StageManager stageManager;

    void Start()
    {
        stageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    void Update()
    {
        if(hpText != null)
        {
            hpText.text = hp.ToString("N0");
        }
        /*if (tower1 == null)
        {
            tower1 = GameObject.Find("Tower1").GetComponent<Tower1>();
        }
        if(tower2 == null)
        {
            tower2 = GameObject.Find("Tower2").GetComponent<Tower2>();
        }
        if (rdTower == null)
        {
            rdTower = GameObject.Find("RandomTower").GetComponent<RandomTower>();
        }*/
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
            GameManager.gameManager.money += enemy_drop_money;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Tower_Attack"))
        {
            hp -= tower1.atk;
            Debug.Log("Ÿ��1�� ����"+tower1.atk);
            //if (hp <= 0)
            //{
            //   Destroy(gameObject);
            //   Debug.Log("�׾���");
            //   gm.money += enemy1_drop_money;
            //}
        }
        if (other.CompareTag("Tower_Attack_2"))
        {
            hp -= tower2.atk;
            Debug.Log("Ÿ��2�� ����"+tower2.atk);

            //if (hp <= 0)
            //{
            //   Destroy(gameObject);
            //   Debug.Log("�׾���");
            //   gm.money += enemy2_drop_money;
            //}
        }
        if (other.CompareTag("Random_Attack"))
        {

            rdTower.atk = Random.Range(rdTower.atk_Min, rdTower.atk_Max);
            Debug.Log(rdTower.atk);
            hp -= rdTower.atk;
            Debug.Log("Random Tower�� ����"+rdTower.atk);
        }
        if (other.CompareTag("Ex_Tower_Attack"))
        {
            hp -= ex_Tower.atk;
            Debug.Log("Ex_Tower�� ����" + ex_Tower.atk);
        }
    }
}
