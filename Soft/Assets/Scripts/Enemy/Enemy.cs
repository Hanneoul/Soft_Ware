using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class Enemy : MonoBehaviour
{
    public TextMesh hpText;
    public float hp; // HP
    public float wp;

    public Tower tower1; // tower1의 공격력
    public Tower tower2;
    public Tower ex_Tower;
    public Tower1 bulletTower;
    public RandomTower rdTower;
    public Bullet1 bullet;

    public float enemy_drop_money; // 드랍머니

    StageManager stageManager;

    public UnityEvent Die_Fade;

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

    }

    void Survive( )
    {        
        if(wp==GameManager.instance.waypoints.Length)
        {
            Debug.Log("살았다");
            this.transform.parent.GetComponent<SpawnManager>().Push(gameObject);
            stageManager.surviveCnt++;
        }
    }

    void Die()
    {
        if (hp <= 0)
        {
            Debug.Log("죽었다");
            Die_Fade.Invoke();
            //오류 : 바로 Push 해버려서 애니메이션이 나오기 전에 없어짐..
            this.transform.parent.GetComponent<SpawnManager>().Push(gameObject);
            GameManager.instance.money += enemy_drop_money;
            GameManager.instance.totalMoney += enemy_drop_money;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Tower_Attack"))
        {
            hp -= tower1.atk;
            Debug.Log("타워1에 맞음 "+tower1.atk);
        }
        if (other.CompareTag("Tower_Attack_2"))
        {
            hp -= tower2.atk;
            Debug.Log("타워2에 맞음 "+tower2.atk);
        }
        if (other.CompareTag("Random_Attack"))
        {
            rdTower.atk = Random.Range(rdTower.atk_Min, rdTower.atk_Max);
            hp -= rdTower.atk;
            Debug.Log("Random Tower에 맞음 "+rdTower.atk);
        }
        if (other.CompareTag("Ex_Tower_Attack"))
        {
            hp -= ex_Tower.atk;
            Debug.Log("Ex_Tower에 맞음 " + ex_Tower.atk);
        }
        if(other.CompareTag("WayPoint"))
        {
            wp++;
            Debug.Log(wp);
        }
        if(other.CompareTag("Coffee1"))
        {
            hp -= bullet.atk;
            Debug.Log("으악");
        }
    }
}
