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

    public float tower1_damage; // tower1�� ���ݷ�
    public float tower2_damage;
    public int randomDmg_min;
    public int randomDmg_max;
    public int randomDmg;
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
        
        Survive();
        Die();        

        randomDmg = Random.Range(randomDmg_min, randomDmg_max);
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
        Debug.Log("�ν�");

        if (other.CompareTag("Tower_Attack"))
        {
            hp -= tower1_damage;
            Debug.Log("Ÿ��1�� ����");
            //if (hp <= 0)
            //{
            //   Destroy(gameObject);
            //   Debug.Log("�׾���");
            //   gm.money += enemy1_drop_money;
            //}
        }
        else if (other.CompareTag("Tower_Attack_2"))
        {
            hp -= tower2_damage;
            Debug.Log("Ÿ��2�� ����");

            //if (hp <= 0)
            //{
            //   Destroy(gameObject);
            //   Debug.Log("�׾���");
            //   gm.money += enemy2_drop_money;
            //}
        }
        else if (other.CompareTag("Random_Attack"))
        {
            Debug.Log("�ƴ� ���� ��ü ��!!!!!!!!!!!");
            hp -= randomDmg;
        }
    }
}
